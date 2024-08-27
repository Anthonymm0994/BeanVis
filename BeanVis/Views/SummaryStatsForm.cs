using BeanVis.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeanVis.Views
{
    public partial class SummaryStatsForm : MaterialForm
    {
        public SummaryStatsForm()
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

            UpdateDatasetComboBox();

            // Subscribe to the event to update the ComboBox when datasets are added
            DataStorageModel.Instance.DatasetsUpdated += UpdateDatasetComboBox;
        }

        private void UpdateDatasetComboBox()
        {
            if (Data_ComboBox.InvokeRequired)
            {
                // If we're not on the UI thread, invoke the method on the UI thread
                Data_ComboBox.Invoke(new Action(UpdateDatasetComboBox));
            }
            else
            {
                // Clear the existing items
                Data_ComboBox.Items.Clear();

                // Add dataset names to the ComboBox
                foreach (var dataset in DataStorageModel.Instance.Datasets)
                {
                    Data_ComboBox.Items.Add(dataset.Name);
                }

                // Optionally select the first item by default
                if (Data_ComboBox.Items.Count > 0)
                {
                    Data_ComboBox.SelectedIndex = 0;
                }
            }
        }

    }
}
