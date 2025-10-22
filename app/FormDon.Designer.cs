namespace app
{
    partial class FormDon
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
            Dokho = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Chude = new GroupBox();
            button8 = new Button();
            button6 = new Button();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button10 = new Button();
            button9 = new Button();
            Dokho.SuspendLayout();
            Chude.SuspendLayout();
            SuspendLayout();
            // 
            // Dokho
            // 
            Dokho.Controls.Add(button3);
            Dokho.Controls.Add(button2);
            Dokho.Controls.Add(button1);
            Dokho.Location = new Point(148, 17);
            Dokho.Name = "Dokho";
            Dokho.Size = new Size(504, 120);
            Dokho.TabIndex = 2;
            Dokho.TabStop = false;
            Dokho.Text = "🕹 Chọn độ khó";
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Location = new Point(375, 51);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 0;
            button3.Text = "🔴 Khó";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.Location = new Point(200, 51);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 0;
            button2.Text = "\U0001f7e1 Trung bình";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(26, 51);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "\U0001f7e2 Dễ";
            button1.UseVisualStyleBackColor = false;
            // 
            // Chude
            // 
            Chude.Controls.Add(button8);
            Chude.Controls.Add(button6);
            Chude.Controls.Add(button7);
            Chude.Controls.Add(button5);
            Chude.Controls.Add(button4);
            Chude.Location = new Point(148, 205);
            Chude.Name = "Chude";
            Chude.Size = new Size(504, 150);
            Chude.TabIndex = 5;
            Chude.TabStop = false;
            Chude.Text = "📚 Chọn chủ đề";
            // 
            // button8
            // 
            button8.BackColor = Color.Moccasin;
            button8.Location = new Point(296, 110);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 0;
            button8.Text = "📒 Lịch sử";
            button8.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LemonChiffon;
            button6.Location = new Point(375, 43);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 0;
            button6.Text = "📙 Vật lý";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightGreen;
            button7.Location = new Point(99, 110);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 0;
            button7.Text = "📗 Địa lý";
            button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Pink;
            button5.Location = new Point(200, 43);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 0;
            button5.Text = "📙 Anh ngữ";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightBlue;
            button4.Location = new Point(26, 43);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 0;
            button4.Text = "📘 Toán học";
            button4.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveBorder;
            button10.Location = new Point(444, 400);
            button10.Name = "button10";
            button10.Size = new Size(112, 34);
            button10.TabIndex = 3;
            button10.Text = "◀ Quay lại";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveCaption;
            button9.Location = new Point(247, 400);
            button9.Name = "button9";
            button9.Size = new Size(112, 34);
            button9.TabIndex = 4;
            button9.Text = "▶ Chơi ngay";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // FormDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Dokho);
            Controls.Add(Chude);
            Controls.Add(button10);
            Controls.Add(button9);
            Name = "FormDon";
            Text = "FormDon";
            Dokho.ResumeLayout(false);
            Chude.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Dokho;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox Chude;
        private Button button8;
        private Button button6;
        private Button button7;
        private Button button5;
        private Button button4;
        private Button button10;
        private Button button9;
    }
}