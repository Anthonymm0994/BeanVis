using BeanVis.Controllers;
using BeanVis.Models;
using BeanVis.Models.CSV;
using Deedle;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BeanVis.Views
{
    public partial class MainForm : MaterialForm
    {
        private readonly MainFormController _controller;
        public MainForm()
        {
            InitializeComponent();
            _controller = new MainFormController();
            // Initialize MaterialSkinManager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Set the theme to DARK
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Set the color scheme for your application
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Purple500, //Changes button color
                Primary.Grey900, //Changes action bar color
                Primary.BlueGrey700,
                Accent.Purple700,
                TextShade.WHITE
            );
        }

        private void AddCsv_Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _controller.AddCsvFiles(openFileDialog.FileNames);
                    _controller.PopulateCheckedListBox(Csv_CheckedListBox);
                }
            }
        }

        private async void LoadData_Button_Click(object sender, EventArgs e)
        {
            var selectedFilePaths = Csv_CheckedListBox.Items
                .OfType<MaterialCheckbox>()
                .Where((item, index) => Csv_CheckedListBox.GetItemCheckState(index) == CheckState.Checked)
                .Select(item => item.Text)
                .ToList();

            if (selectedFilePaths.Count == 0)
            {
                MessageBox.Show("No items selected. Please select files before proceeding.");
                return;
            }

            var existingDatasetNames = DataStorageModel.Instance.Datasets.Select(ds => ds.Name).ToList();

            using (var namingForm = new DatasetNamingForm(selectedFilePaths, existingDatasetNames))
            {
                namingForm.ShowDialog();

                if (namingForm.DialogResult == DialogResult.OK)
                {
                    var namedDatasets = namingForm.GetNamedDatasets();
                    await LoadDatasetsAsync(namedDatasets);
                    UpdateDataSets_MaterialListBox(); // Update the list box after loading
                }
            }
        }

        private async Task LoadDatasetsAsync(Dictionary<string, string> namedDatasets)
        {
            MaterialProgressBar progressBar = new MaterialProgressBar
            {
                Minimum = 0,
                Maximum = namedDatasets.Count,
                Step = 1,
                Value = 0
            };
            Controls.Add(progressBar);

            int progress = 0;

            await Task.Run(() =>
            {
                foreach (var kvp in namedDatasets)
                {
                    var dataFrame = new CsvReader(kvp.Key).LoadCsv();
                    var datasetModel = new DatasetModel(kvp.Value, dataFrame);

                    DataStorageModel.Instance.AddDataset(datasetModel);

                    progress++;
                    progressBar.Invoke((Action)(() =>
                    {
                        progressBar.Value = progress;
                    }));
                }
            });

            Controls.Remove(progressBar);
            MessageBox.Show("Data loading complete!");
        }

        // Method to update the DataSets_MaterialListBox
        private void UpdateDataSets_MaterialListBox()
        {
            DataSets_MaterialListBox.Items.Clear();

            foreach (var dataset in DataStorageModel.Instance?.Datasets)
            {
                DataSets_MaterialListBox.Items.Add(new MaterialListBoxItem(dataset.Name));
            }
        }

        private void SummaryStats_Button_Click(object sender, EventArgs e)
        {
            SummaryStatsForm newSummaryStatsForm = new SummaryStatsForm();
            newSummaryStatsForm.Show();
        }

        private void DistributionAnalysis_Button_Click(object sender, EventArgs e)
        {
            DistributionAnalysisForm distributionAnalysisForm = new DistributionAnalysisForm();
            distributionAnalysisForm.Show();
        }
    }
}
