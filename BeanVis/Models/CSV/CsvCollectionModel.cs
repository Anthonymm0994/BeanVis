using System.Collections.Generic;

namespace BeanVis.Models.CSV
{
    public class CsvCollectionModel
    {
        private List<CsvModel> _csvFiles = new List<CsvModel>();

        public IReadOnlyList<CsvModel> CsvFiles => _csvFiles.AsReadOnly();

        public void AddCsvFile(string filePath)
        {
            if (!_csvFiles.Exists(file => file.FilePath == filePath))
            {
                _csvFiles.Add(new CsvModel(filePath));
            }
        }

        public void ClearCsvFiles()
        {
            _csvFiles.Clear();
        }
    }
}
