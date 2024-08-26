using BeanVis.Controllers;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BeanVis.Views
{
    public partial class DatasetNamingForm : MaterialForm
    {
        private readonly DatasetNamingController _controller;

        public DatasetNamingForm(List<string> filePaths, List<string> existingDatasetNames)
        {
            InitializeComponent();

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

            _controller = new DatasetNamingController(filePaths, existingDatasetNames);
            _controller.InitializeNamedDatasets();

            InitializeForm();
        }

        private void InitializeForm()
        {
            var tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = _controller.GetNamedDatasets().Count,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(10)
            };

            foreach (var filePath in _controller.GetNamedDatasets().Keys)
            {
                var materialCard = new MaterialCard
                {
                    Dock = DockStyle.Top,
                    Padding = new Padding(14),
                    Height = 100
                };

                var label = new MaterialLabel
                {
                    Text = $"File: {filePath}",
                    Dock = DockStyle.Top,
                    Font = new Font("Roboto", 10, FontStyle.Regular)
                };

                var textBox = new MaterialTextBox
                {
                    Text = _controller.GetNamedDatasets()[filePath],
                    Dock = DockStyle.Top,
                    Width = 300
                };

                textBox.TextChanged += (sender, e) =>
                {
                    if (_controller.GetNamedDatasets().Values.Contains(textBox.Text))
                    {
                        textBox.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        textBox.BackColor = Color.White;
                        _controller.UpdateDatasetName(filePath, textBox.Text);
                    }
                };

                materialCard.Controls.Add(textBox);
                materialCard.Controls.Add(label);

                tableLayoutPanel.Controls.Add(materialCard);
            }

            var saveButton = new MaterialButton
            {
                Text = "Save",
                Dock = DockStyle.Bottom,
                Height = 36
            };
            saveButton.Click += (sender, e) =>
            {
                DialogResult = DialogResult.OK;
                Close();
            };

            Controls.Add(tableLayoutPanel);
            Controls.Add(saveButton);
        }

        public Dictionary<string, string> GetNamedDatasets()
        {
            return _controller.GetNamedDatasets();
        }
    }
}
