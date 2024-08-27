using BeanVis.Models;
using Deedle;
using MaterialSkin;
using MaterialSkin.Controls;
using ScottPlot.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BeanVis.Views
{
    public partial class DistributionAnalysisForm : MaterialForm
    {
        private int plotCount = 0; // Keep track of the number of plots added
        private FormsPlot firstPlot = null; // Reference to the first plot for axis linking
        private List<FormsPlot> plots = new List<FormsPlot>(); // List to keep track of all plots
        private Frame<int, string> dataFrame; // Your DataFrame

        public DistributionAnalysisForm()
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

            Data_ComboBox.SelectedIndexChanged += OnDatasetSelected;
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

                // Set the DisplayMember to "Name" so the ComboBox shows the Name property
                Data_ComboBox.DisplayMember = "Name";

                // Add DatasetModel objects to the ComboBox
                foreach (var dataset in DataStorageModel.Instance.Datasets)
                {
                    Data_ComboBox.Items.Add(dataset);
                }

                // Automatically select the dataset if there's only one
                if (Data_ComboBox.Items.Count == 1)
                {
                    Data_ComboBox.SelectedIndex = 0;
                    OnDatasetSelected(Data_ComboBox, EventArgs.Empty); // Trigger dataset selection
                }
                else if (Data_ComboBox.Items.Count > 0)
                {
                    Data_ComboBox.SelectedIndex = 0; // Optionally select the first item by default
                }
            }
        }

        private void OnDatasetSelected(object sender, EventArgs e)
        {
            // Get the selected dataset from the ComboBox as DatasetModel
            var selectedDataset = Data_ComboBox.SelectedItem as DatasetModel;

            if (selectedDataset != null)
            {
                // Set the dataFrame to the selected dataset's DataFrame
                dataFrame = selectedDataset.DataFrame;

                // Populate the ComboBoxes with the columns from the selected dataset
                PopulateColumnComboBoxes(dataFrame);

                // Create box plots for each numerical column
                CreateBoxPlots();
            }
        }

        private void PopulateColumnComboBoxes(Frame<int, string> dataFrame)
        {
            // Identify all numerical columns in the DataFrame
            var numericalColumns = dataFrame.ColumnKeys
                .Where(columnKey => IsNumericColumn(dataFrame, columnKey))
                .ToList();

            // Populate the X and Y ComboBoxes with these columns
            XAxis_ComboBox.Items.Clear();
            YAxis_ComboBox.Items.Clear();

            XAxis_ComboBox.Items.AddRange(numericalColumns.ToArray());
            YAxis_ComboBox.Items.AddRange(numericalColumns.ToArray());
        }

        private bool IsNumericColumn(Frame<int, string> dataFrame, string columnKey)
        {
            // Try to access the series as double
            try
            {
                var series = dataFrame.GetColumn<double>(columnKey);
                return true; // If it successfully converts, it's numeric
            }
            catch
            {
                return false; // If it throws an exception, it's not numeric
            }
        }

        private void UpdateTableLayout(int numberOfPlots)
        {
            // Clear the TableLayoutPanel
            ScottPlot_TableLayout.Controls.Clear();
            ScottPlot_TableLayout.RowStyles.Clear();
            ScottPlot_TableLayout.ColumnStyles.Clear();

            if (numberOfPlots == 1)
            {
                // 1 plot, take up the whole panel
                ScottPlot_TableLayout.RowCount = 1;
                ScottPlot_TableLayout.ColumnCount = 1;
                ScottPlot_TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            }
            else if (numberOfPlots == 2)
            {
                // 2 plots, split the panel in half horizontally
                ScottPlot_TableLayout.RowCount = 1;
                ScottPlot_TableLayout.ColumnCount = 2;
                ScottPlot_TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            }
            else if (numberOfPlots == 3)
            {
                // 3 plots: top half has 2 plots, bottom half has 1 plot
                ScottPlot_TableLayout.RowCount = 2;
                ScottPlot_TableLayout.ColumnCount = 2;
                ScottPlot_TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                ScottPlot_TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            }
            else if (numberOfPlots == 4)
            {
                // 4 plots, each takes one square
                ScottPlot_TableLayout.RowCount = 2;
                ScottPlot_TableLayout.ColumnCount = 2;
                ScottPlot_TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                ScottPlot_TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            }
        }

        private void AddPlot_Button_Click(object sender, EventArgs e)
        {
            if (dataFrame == null)
            {
                MessageBox.Show("No dataset is currently loaded. Please select a dataset first.");
                return;
            }

            string xAxisKey = XAxis_ComboBox.SelectedItem?.ToString();
            string yAxisKey = YAxis_ComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(xAxisKey) || string.IsNullOrEmpty(yAxisKey))
            {
                MessageBox.Show("Please select both X and Y axes.");
                return;
            }

            if (plotCount >= 4)
            {
                MessageBox.Show("All squares are already filled with plots.");
                return;
            }

            if (!IsNumericColumn(dataFrame, xAxisKey) || !IsNumericColumn(dataFrame, yAxisKey))
            {
                MessageBox.Show("Selected columns must be numeric.");
                return;
            }

            FormsPlot newPlot = new FormsPlot
            {
                Dock = DockStyle.Fill
            };

            try
            {
                var xData = dataFrame.GetColumn<double>(xAxisKey).Values.ToArray();
                var yData = dataFrame.GetColumn<double>(yAxisKey).Values.ToArray();

                newPlot.Plot.Add.Scatter(xData, yData);
                newPlot.Plot.XLabel(xAxisKey);
                newPlot.Plot.YLabel(yAxisKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while plotting data: {ex.Message}");
                return;
            }

            foreach (var plot in plots)
            {
                newPlot.Plot.Axes.Link(plot.Plot, x: true, y: true);
                plot.Plot.Axes.Link(newPlot.Plot, x: true, y: true);
            }

            plots.Add(newPlot);

            switch (plotCount)
            {
                case 0:
                    ScottPlot_TableLayout.RowCount = 1;
                    ScottPlot_TableLayout.ColumnCount = 1;
                    ScottPlot_TableLayout.RowStyles.Clear();
                    ScottPlot_TableLayout.ColumnStyles.Clear();
                    ScottPlot_TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    ScottPlot_TableLayout.Controls.Add(newPlot, 0, 0);
                    break;

                case 1:
                    ScottPlot_TableLayout.ColumnCount = 2;
                    ScottPlot_TableLayout.ColumnStyles.Clear();
                    ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    ScottPlot_TableLayout.Controls.Add(newPlot, 1, 0);
                    break;

                case 2:
                    ScottPlot_TableLayout.RowCount = 2;
                    ScottPlot_TableLayout.ColumnCount = 2;
                    ScottPlot_TableLayout.RowStyles.Clear();
                    ScottPlot_TableLayout.ColumnStyles.Clear();
                    ScottPlot_TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    ScottPlot_TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    ScottPlot_TableLayout.Controls.Add(plots[0], 0, 0);
                    ScottPlot_TableLayout.Controls.Add(plots[1], 1, 0);
                    ScottPlot_TableLayout.Controls.Add(newPlot, 0, 1);
                    break;

                case 3:
                    ScottPlot_TableLayout.Controls.Add(newPlot, 1, 1);
                    break;
            }

            plotCount++;
            newPlot.Refresh();
        }

        private void CreateBoxPlots()
        {
            // Clear any existing plots
            BoxPlot.Plot.Clear();

            // Initialize position for box plots on the x-axis
            int position = 1;

            // Set limits for y-axis
            double yMin = double.MaxValue;
            double yMax = double.MinValue;

            // Collect the labels and positions for the x-axis
            var xLabels = new List<string>();
            var xPositions = new List<double>();

            foreach (var columnKey in dataFrame.ColumnKeys)
            {
                // Ensure the column is numeric
                if (!IsNumericColumn(dataFrame, columnKey))
                    continue;

                // Extract the data
                var data = dataFrame.GetColumn<double>(columnKey).Values.ToArray();

                // Calculate the necessary statistics for the box plot
                double boxMin = GetPercentile(data, 25); // Q1
                double boxMax = GetPercentile(data, 75); // Q3
                double whiskerMin = data.Min(); // Min value
                double whiskerMax = data.Max(); // Max value
                double boxMiddle = GetPercentile(data, 50); // Median

                // Update global min/max for y-axis limits
                yMin = Math.Min(yMin, whiskerMin);
                yMax = Math.Max(yMax, whiskerMax);

                // Create a box plot for this column
                var box = new ScottPlot.Box
                {
                    Position = position,
                    BoxMin = boxMin,
                    BoxMax = boxMax,
                    WhiskerMin = whiskerMin,
                    WhiskerMax = whiskerMax,
                    BoxMiddle = boxMiddle,
                    Label = columnKey // Use the column name as the label for the legend
                };

                // Add the box plot to the plot
                BoxPlot.Plot.Add.Box(box);

                // Store the position and label for the x-axis
                xPositions.Add(position);
                xLabels.Add(columnKey);

                // Increment position for the next box plot
                position++;
            }

            // Set x-axis labels and their positions using SetTicks
            BoxPlot.Plot.Axes.Bottom.SetTicks(xPositions.ToArray(), xLabels.ToArray());

            // Set the axis labels to be more descriptive
            BoxPlot.Plot.XLabel("Features");
            BoxPlot.Plot.YLabel("Distribution of Values");

            // Add a legend to the plot
            BoxPlot.Plot.Legend(true);

            // Auto-scale the axis limits to fit the data
            BoxPlot.Plot.Axes.AutoScale();

            // Refresh the plot to display it
            BoxPlot.Refresh();
        }





        // Helper method to calculate percentiles
        private double GetPercentile(double[] data, double percentile)
        {
            Array.Sort(data);
            int N = data.Length;
            double n = (N - 1) * percentile / 100.0 + 1;

            if (n == 1d) return data[0];
            else if (n == N) return data[N - 1];
            else
            {
                int k = (int)n;
                double d = n - k;
                return data[k - 1] + d * (data[k] - data[k - 1]);
            }
        }
    }
}
