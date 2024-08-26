using Deedle;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace BeanVis.Models.CSV
{
    public static class CsvTypeInference
    {
        // Infers the type of a column based on the sample rows
        public static Type InferColumnType(string[] sampleValues)
        {
            if (sampleValues.All(value => double.TryParse(value, out _) || string.IsNullOrWhiteSpace(value) || value == "-"))
            {
                return typeof(double);
            }
            if (sampleValues.All(value => DateTime.TryParse(value, out _) || string.IsNullOrWhiteSpace(value) || value == "-"))
            {
                return typeof(DateTime);
            }
            return typeof(string); // Default to string if it can't be inferred as double or DateTime
        }

        // Reads the sample rows to infer types
        public static Type[] InferTypes(string filePath, int sampleSize = 100, int skipLinesTop = 0)
        {
            using var reader = new StreamReader(filePath);
            for (int i = 0; i < skipLinesTop; i++)
            {
                reader.ReadLine(); // Skip initial lines if needed
            }

            var firstLine = reader.ReadLine();
            if (firstLine == null)
            {
                throw new InvalidOperationException("The CSV file is empty.");
            }

            var headers = firstLine.Split(',');

            // Read the sample rows
            var sampleRows = new string[sampleSize][];
            for (int i = 0; i < sampleSize; i++)
            {
                var line = reader.ReadLine();
                if (line == null) break;
                sampleRows[i] = line.Split(',');
            }

            // Infer the type for each column
            var types = new Type[headers.Length];
            for (int colIndex = 0; colIndex < headers.Length; colIndex++)
            {
                var sampleValues = sampleRows.Select(row => row[colIndex]).ToArray();
                types[colIndex] = InferColumnType(sampleValues);
            }

            return types;
        }

        public static Frame<int, string> ReadCsvWithInferredTypes(string filePath, Type[] inferredTypes, int skipLinesTop = 0)
        {
            // Open and process the file stream
            using var fileStream = File.OpenRead(filePath);

            // Manually skip lines at the top
            using (var reader = new StreamReader(fileStream))
            {
                for (int i = 0; i < skipLinesTop; i++)
                {
                    reader.ReadLine();
                }
            }

            // Reopen the stream for reading into a Frame
            using var frameStream = File.OpenRead(filePath);

            // Read the CSV into a Frame
            var frame = Frame.ReadCsv(
                frameStream,
                hasHeaders: true,
                inferTypes: false
            );

            // Create a dictionary to hold the series with correctly inferred types
            var seriesDict = new Dictionary<string, Series<int, object>>();

            // Process each column to handle placeholders and unexpected formats
            foreach (var colName in frame.ColumnKeys)
            {
                var columnIndex = frame.ColumnKeys.ToList().IndexOf(colName);
                var columnType = inferredTypes[columnIndex];

                Console.WriteLine($"Processing column '{colName}' inferred as '{columnType.Name}'");

                if (columnType == typeof(double))
                {
                    var series = frame[colName].Select(value =>
                    {
                        var stringValue = Convert.ToString(value);

                        // Handle non-numeric or unexpected formats
                        if (string.IsNullOrWhiteSpace(stringValue) || stringValue == "-" || !double.TryParse(stringValue, out _))
                        {
                            return (object)Double.NaN;
                        }
                        return (object)Convert.ToDouble(stringValue);
                    });
                    seriesDict[colName] = series;
                }
                else if (columnType == typeof(DateTime))
                {
                    var series = frame[colName].Select(value =>
                    {
                        var stringValue = Convert.ToString(value);
                        if (string.IsNullOrWhiteSpace(stringValue) || stringValue == "-")
                            return (object)DateTime.MinValue;
                        return (object)DateTime.Parse(stringValue, CultureInfo.InvariantCulture);
                    });
                    seriesDict[colName] = series;
                }
                else // String column
                {
                    var series = frame[colName].Select(value =>
                    {
                        var stringValue = Convert.ToString(value);
                        Console.WriteLine($"Processing value '{stringValue}' in string column '{colName}'");
                        if (string.IsNullOrWhiteSpace(stringValue) || stringValue == "-")
                            return null;
                        return (object)stringValue;
                    });
                    seriesDict[colName] = series;
                }
            }

            // Create a new frame from the dictionary of series
            return Frame.FromColumns(seriesDict);
        }



    }
}
