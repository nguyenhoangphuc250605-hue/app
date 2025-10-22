namespace app
{
    partial class Bangxephang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panelHeader = new Panel();
            labelTitle = new Label();
            pictureBoxTitle = new PictureBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitle).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(248, 249, 250);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(236, 240, 241);
            dataGridView1.Location = new Point(90, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(606, 300);
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(40, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 60);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "🎯 Chơi đơn", "👥 Chơi đa" });
            comboBox1.Location = new Point(224, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 38);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(55, 71, 79);
            label2.Location = new Point(36, 12);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 0;
            label2.Text = "🎮 Chế độ:";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(99, 500);
            button1.Name = "button1";
            button1.Size = new Size(170, 45);
            button1.TabIndex = 3;
            button1.Text = "🔄 Làm mới";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(231, 76, 60);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(520, 500);
            button2.Name = "button2";
            button2.Size = new Size(140, 45);
            button2.TabIndex = 4;
            button2.Text = "⬅️ Quay lại";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(650, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 144, 255);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Controls.Add(pictureBoxTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 80);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(90, 22);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(500, 65);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "🏆 BẢNG XẾP HẠNG";
            // 
            // pictureBoxTitle
            // 
            pictureBoxTitle.Location = new Point(20, 20);
            pictureBoxTitle.Name = "pictureBoxTitle";
            pictureBoxTitle.Size = new Size(60, 60);
            pictureBoxTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTitle.TabIndex = 0;
            pictureBoxTitle.TabStop = false;
            // 
            // Column1
            // 
            Column1.FillWeight = 80F;
            Column1.HeaderText = "\U0001f947 Vị trí";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.FillWeight = 150F;
            Column2.HeaderText = "👤 Tên ";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "⭐ Điểm";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.FillWeight = 120F;
            Column4.HeaderText = "⏱️ Thời gian";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 150;
            // 
            // Bangxephang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(800, 580);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bangxephang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng Xếp Hạng";
            Load += Bangxephang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitle).EndInit();
            ResumeLayout(false);
        }

        #region Designer Controls
        private Panel panelHeader;
        private Label labelTitle;
        private PictureBox pictureBoxTitle;
        private Panel panel1;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        #endregion

        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}