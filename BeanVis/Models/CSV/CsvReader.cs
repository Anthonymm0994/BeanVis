using Deedle;
using System;

namespace BeanVis.Models.CSV
{
    public class CsvReader
    {
        private readonly string _filePath;
        private readonly int _sampleSize;
        private readonly int _skipLinesTop;

        public CsvReader(string filePath, int sampleSize = 100, int skipLinesTop = 0)
        {
            _filePath = filePath;
            _sampleSize = sampleSize;
            _skipLinesTop = skipLinesTop;
        }

        public Frame<int, string> LoadCsv()
        {
            var inferredTypes = CsvTypeInference.InferTypes(_filePath, _sampleSize, _skipLinesTop);
            //var frame = CsvTypeInference.ReadCsvWithInferredTypes(_filePath, inferredTypes, _skipLinesTop);
            var frame = Frame.ReadCsv(_filePath, inferTypes: true);
            return frame;
        }
    }
}
