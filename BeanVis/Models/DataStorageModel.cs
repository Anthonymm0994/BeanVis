using System;
using System.Collections.Generic;

namespace BeanVis.Models
{
    public class DataStorageModel
    {
        private static DataStorageModel _instance;
        public static DataStorageModel Instance => _instance ?? (_instance = new DataStorageModel());

        private List<DatasetModel> _datasets = new List<DatasetModel>();

        public event Action DatasetsUpdated;

        private DataStorageModel() { }

        public IReadOnlyList<DatasetModel> Datasets => _datasets.AsReadOnly();

        public void AddDataset(DatasetModel dataset)
        {
            _datasets.Add(dataset);
            DatasetsUpdated?.Invoke();
        }
    }
}
