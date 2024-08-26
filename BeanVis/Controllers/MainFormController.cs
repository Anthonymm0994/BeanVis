using BeanVis.Models.CSV;
using MaterialSkin.Controls;
using System.Collections.Generic;

namespace BeanVis.Controllers
{
    public class MainFormController
    {
        private readonly CsvCollectionModel _csvFileCollection;

        public MainFormController()
        {
            _csvFileCollection = new(); // Assuming this is how you initialize your collection
        }

        public void AddCsvFiles(IEnumerable<string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                _csvFileCollection.AddCsvFile(filePath);
            }
        }

        public void PopulateCheckedListBox(MaterialCheckedListBox checkedListBox)
        {
            checkedListBox.Items.Clear();
            foreach (var csvFile in _csvFileCollection.CsvFiles)
            {
                checkedListBox.Items.Add(csvFile.FilePath, false);
            }
        }
    }
}
