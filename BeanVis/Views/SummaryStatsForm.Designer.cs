namespace BeanVis.Views
{
    partial class SummaryStatsForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel4 = new TableLayoutPanel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            FileSize_Label = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            FileName_Label = new MaterialSkin.Controls.MaterialLabel();
            Data_ComboBox = new MaterialSkin.Controls.MaterialComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            materialCard1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.3979836F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.6020164F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.7352257F));
            tableLayoutPanel1.Size = new Size(1194, 773);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(materialCard2, 0, 2);
            tableLayoutPanel2.Controls.Add(materialCard1, 0, 1);
            tableLayoutPanel2.Controls.Add(Data_ComboBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.84892F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.15108F));
            tableLayoutPanel2.Size = new Size(428, 767);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(30, 353);
            materialCard2.Margin = new Padding(30);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(368, 384);
            materialCard2.TabIndex = 2;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(tableLayoutPanel4);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(30, 71);
            materialCard1.Margin = new Padding(30);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(368, 222);
            materialCard1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(materialLabel10, 1, 4);
            tableLayoutPanel4.Controls.Add(materialLabel9, 0, 4);
            tableLayoutPanel4.Controls.Add(materialLabel8, 1, 3);
            tableLayoutPanel4.Controls.Add(materialLabel7, 0, 3);
            tableLayoutPanel4.Controls.Add(materialLabel6, 1, 2);
            tableLayoutPanel4.Controls.Add(materialLabel5, 0, 2);
            tableLayoutPanel4.Controls.Add(materialLabel4, 1, 1);
            tableLayoutPanel4.Controls.Add(FileSize_Label, 0, 1);
            tableLayoutPanel4.Controls.Add(materialLabel2, 1, 0);
            tableLayoutPanel4.Controls.Add(FileName_Label, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(14, 14);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel4.Size = new Size(340, 194);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Dock = DockStyle.Fill;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(173, 158);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(164, 36);
            materialLabel10.TabIndex = 9;
            materialLabel10.Text = "materialLabel10";
            materialLabel10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Dock = DockStyle.Fill;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(3, 158);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(164, 36);
            materialLabel9.TabIndex = 8;
            materialLabel9.Text = "materialLabel9";
            materialLabel9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Dock = DockStyle.Fill;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(173, 114);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(164, 44);
            materialLabel8.TabIndex = 7;
            materialLabel8.Text = "materialLabel8";
            materialLabel8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Dock = DockStyle.Fill;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(3, 114);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(164, 44);
            materialLabel7.TabIndex = 6;
            materialLabel7.Text = "materialLabel7";
            materialLabel7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Dock = DockStyle.Fill;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(173, 68);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(164, 46);
            materialLabel6.TabIndex = 5;
            materialLabel6.Text = "materialLabel6";
            materialLabel6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Dock = DockStyle.Fill;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(3, 68);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(164, 46);
            materialLabel5.TabIndex = 4;
            materialLabel5.Text = "materialLabel5";
            materialLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Dock = DockStyle.Fill;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(173, 34);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(164, 34);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "materialLabel4";
            materialLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FileSize_Label
            // 
            FileSize_Label.AutoSize = true;
            FileSize_Label.Depth = 0;
            FileSize_Label.Dock = DockStyle.Fill;
            FileSize_Label.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            FileSize_Label.Location = new Point(3, 34);
            FileSize_Label.MouseState = MaterialSkin.MouseState.HOVER;
            FileSize_Label.Name = "FileSize_Label";
            FileSize_Label.Size = new Size(164, 34);
            FileSize_Label.TabIndex = 2;
            FileSize_Label.Text = "File Size";
            FileSize_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Fill;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(173, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(164, 34);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "materialLabel2";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FileName_Label
            // 
            FileName_Label.AutoSize = true;
            FileName_Label.Depth = 0;
            FileName_Label.Dock = DockStyle.Fill;
            FileName_Label.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            FileName_Label.Location = new Point(3, 0);
            FileName_Label.MouseState = MaterialSkin.MouseState.HOVER;
            FileName_Label.Name = "FileName_Label";
            FileName_Label.Size = new Size(164, 34);
            FileName_Label.TabIndex = 0;
            FileName_Label.Text = "File Name";
            FileName_Label.TextAlign = ContentAlignment.MiddleCenter;
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
            Data_ComboBox.Size = new Size(422, 49);
            Data_ComboBox.StartIndex = 0;
            Data_ComboBox.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(materialCard3, 0, 0);
            tableLayoutPanel3.Controls.Add(materialCard4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(437, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 52.7577934F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2422066F));
            tableLayoutPanel3.Size = new Size(754, 767);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Depth = 0;
            materialCard3.Dock = DockStyle.Fill;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(30, 30);
            materialCard3.Margin = new Padding(30);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(694, 344);
            materialCard3.TabIndex = 0;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Depth = 0;
            materialCard4.Dock = DockStyle.Fill;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(30, 434);
            materialCard4.Margin = new Padding(30);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(694, 303);
            materialCard4.TabIndex = 1;
            // 
            // SummaryStatsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(tableLayoutPanel1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "SummaryStatsForm";
            Padding = new Padding(3, 24, 3, 3);
            Text = "SummaryStatsForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel FileSize_Label;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel FileName_Label;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialComboBox Data_ComboBox;
    }
}