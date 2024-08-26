using BeanVis.Models;
using System.Collections.Generic;

namespace BeanVis.Controllers
{
    public class DatasetNamingController
    {
        private readonly List<string> _filePaths;
        private readonly List<string> _existingDatasetNames;
        private readonly Dictionary<string, string> _namedDatasets;

        public DatasetNamingController(List<string> filePaths, List<string> existingDatasetNames)
        {
            _filePaths = filePaths;
            _existingDatasetNames = existingDatasetNames;
            _namedDatasets = new Dictionary<string, string>();
        }

        public void InitializeNamedDatasets()
        {
            foreach (var filePath in _filePaths)
            {
                var defaultName = System.IO.Path.GetFileNameWithoutExtension(filePath);
                _namedDatasets[filePath] = defaultName;
            }
        }

        public void UpdateDatasetName(string filePath, string newName)
        {
            if (_namedDatasets.ContainsKey(filePath))
            {
                _namedDatasets[filePath] = newName;
            }
        }

        public Dictionary<string, string> GetNamedDatasets()
        {
            return _namedDatasets;
        }
    }
}
