namespace BeanVis.Views
{
    partial class DistributionAnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Data_ComboBox = new MaterialSkin.Controls.MaterialComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            YAxis_ComboBox = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            XAxis_ComboBox = new MaterialSkin.Controls.MaterialComboBox();
            AddPlot_Button = new MaterialSkin.Controls.MaterialButton();
            ScottPlot_TableLayout = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            BoxPlot = new ScottPlot.WinForms.FormsPlot();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            materialCard3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1672, 1219);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.072478F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.92752F));
            tableLayoutPanel1.Size = new Size(1672, 1219);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1175F));
            tableLayoutPanel2.Controls.Add(Data_ComboBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1666, 68);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // Data_ComboBox
            // 
            Data_ComboBox.AutoResize = false;
            Data_ComboBox.BackColor = Color.FromArgb(255, 255, 255);
            Data_ComboBox.Depth = 0;
            Data_ComboBox.Dock = DockStyle.Fill;
            Data_ComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            Data_ComboBox.DropDownHeight = 174;
            Data_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Data_ComboBox.DropDownWidth = 121;
            Data_ComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Data_ComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Data_ComboBox.FormattingEnabled = true;
            Data_ComboBox.IntegralHeight = false;
            Data_ComboBox.ItemHeight = 43;
            Data_ComboBox.Location = new Point(3, 3);
            Data_ComboBox.MaxDropDownItems = 4;
            Data_ComboBox.MouseState = MaterialSkin.MouseState.OUT;
            Data_ComboBox.Name = "Data_ComboBox";
            Data_ComboBox.Size = new Size(485, 49);
            Data_ComboBox.StartIndex = 0;
            Data_ComboBox.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(materialCard3, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 77);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 64.43594F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35.5640526F));
            tableLayoutPanel3.Size = new Size(1666, 1139);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(tableLayoutPanel5);
            materialCard3.Depth = 0;
            materialCard3.Dock = DockStyle.Fill;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(14, 14);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(1638, 705);
            materialCard3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Controls.Add(ScottPlot_TableLayout, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(14, 14);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.567208F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 91.43279F));
            tableLayoutPanel5.Size = new Size(1610, 677);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 6;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.0833321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.9166679F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 207F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 288F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 467F));
            tableLayoutPanel6.Controls.Add(YAxis_ComboBox, 3, 0);
            tableLayoutPanel6.Controls.Add(materialLabel2, 2, 0);
            tableLayoutPanel6.Controls.Add(materialLabel1, 0, 0);
            tableLayoutPanel6.Controls.Add(XAxis_ComboBox, 1, 0);
            tableLayoutPanel6.Controls.Add(AddPlot_Button, 4, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(1604, 52);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // YAxis_ComboBox
            // 
            YAxis_ComboBox.AutoResize = false;
            YAxis_ComboBox.BackColor = Color.FromArgb(255, 255, 255);
            YAxis_ComboBox.Depth = 0;
            YAxis_ComboBox.Dock = DockStyle.Fill;
            YAxis_ComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            YAxis_ComboBox.DropDownHeight = 174;
            YAxis_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            YAxis_ComboBox.DropDownWidth = 121;
            YAxis_ComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            YAxis_ComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            YAxis_ComboBox.FormattingEnabled = true;
            YAxis_ComboBox.IntegralHeight = false;
            YAxis_ComboBox.ItemHeight = 43;
            YAxis_ComboBox.Location = new Point(644, 3);
            YAxis_ComboBox.MaxDropDownItems = 4;
            YAxis_ComboBox.MouseState = MaterialSkin.MouseState.OUT;
            YAxis_ComboBox.Name = "YAxis_ComboBox";
            YAxis_ComboBox.Size = new Size(201, 49);
            YAxis_ComboBox.StartIndex = 0;
            YAxis_ComboBox.TabIndex = 3;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Fill;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(423, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(215, 52);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "materialLabel2";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Fill;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(3, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(213, 52);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "materialLabel1";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // XAxis_ComboBox
            // 
            XAxis_ComboBox.AutoResize = false;
            XAxis_ComboBox.BackColor = Color.FromArgb(255, 255, 255);
            XAxis_ComboBox.Depth = 0;
            XAxis_ComboBox.Dock = DockStyle.Fill;
            XAxis_ComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            XAxis_ComboBox.DropDownHeight = 174;
            XAxis_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            XAxis_ComboBox.DropDownWidth = 121;
            XAxis_ComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            XAxis_ComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            XAxis_ComboBox.FormattingEnabled = true;
            XAxis_ComboBox.IntegralHeight = false;
            XAxis_ComboBox.ItemHeight = 43;
            XAxis_ComboBox.Location = new Point(222, 3);
            XAxis_ComboBox.MaxDropDownItems = 4;
            XAxis_ComboBox.MouseState = MaterialSkin.MouseState.OUT;
            XAxis_ComboBox.Name = "XAxis_ComboBox";
            XAxis_ComboBox.Size = new Size(195, 49);
            XAxis_ComboBox.StartIndex = 0;
            XAxis_ComboBox.TabIndex = 1;
            // 
            // AddPlot_Button
            // 
            AddPlot_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddPlot_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddPlot_Button.Depth = 0;
            AddPlot_Button.Dock = DockStyle.Fill;
            AddPlot_Button.HighEmphasis = true;
            AddPlot_Button.Icon = null;
            AddPlot_Button.Location = new Point(852, 6);
            AddPlot_Button.Margin = new Padding(4, 6, 4, 6);
            AddPlot_Button.MouseState = MaterialSkin.MouseState.HOVER;
            AddPlot_Button.Name = "AddPlot_Button";
            AddPlot_Button.NoAccentTextColor = Color.Empty;
            AddPlot_Button.Size = new Size(280, 40);
            AddPlot_Button.TabIndex = 4;
            AddPlot_Button.Text = "materialButton1";
            AddPlot_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddPlot_Button.UseAccentColor = false;
            AddPlot_Button.UseVisualStyleBackColor = true;
            AddPlot_Button.Click += AddPlot_Button_Click;
            // 
            // ScottPlot_TableLayout
            // 
            ScottPlot_TableLayout.ColumnCount = 1;
            ScottPlot_TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ScottPlot_TableLayout.Dock = DockStyle.Fill;
            ScottPlot_TableLayout.Location = new Point(3, 61);
            ScottPlot_TableLayout.Name = "ScottPlot_TableLayout";
            ScottPlot_TableLayout.RowCount = 1;
            ScottPlot_TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ScottPlot_TableLayout.Size = new Size(1604, 613);
            ScottPlot_TableLayout.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 812F));
            tableLayoutPanel4.Controls.Add(materialCard2, 1, 0);
            tableLayoutPanel4.Controls.Add(materialCard1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 736);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1660, 400);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(862, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(784, 372);
            materialCard2.TabIndex = 1;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(BoxPlot);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(820, 372);
            materialCard1.TabIndex = 0;
            // 
            // BoxPlot
            // 
            BoxPlot.DisplayScale = 1.5F;
            BoxPlot.Dock = DockStyle.Fill;
            BoxPlot.Location = new Point(14, 14);
            BoxPlot.Name = "BoxPlot";
            BoxPlot.Size = new Size(792, 344);
            BoxPlot.TabIndex = 0;
            // 
            // DistributionAnalysisForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1678, 1286);
            Controls.Add(panel1);
            Name = "DistributionAnalysisForm";
            Text = "DistributionAnalysisForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialComboBox Data_ComboBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox YAxis_ComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox XAxis_ComboBox;
        private MaterialSkin.Controls.MaterialButton AddPlot_Button;
        private TableLayoutPanel ScottPlot_TableLayout;
        private ScottPlot.WinForms.FormsPlot BoxPlot;
    }
}