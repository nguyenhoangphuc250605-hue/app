namespace app
{
    partial class FormGame
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
            btnSingle = new Button();
            btnMulti = new Button();
            btnBangxephang = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnSingle
            // 
            btnSingle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnSingle.Location = new Point(246, 48);
            btnSingle.Name = "btnSingle";
            btnSingle.Size = new Size(286, 50);
            btnSingle.TabIndex = 6;
            btnSingle.Text = "🎯 Chơi đơn";
            btnSingle.Click += btnSingle_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnMulti.Location = new Point(246, 131);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(286, 50);
            btnMulti.TabIndex = 7;
            btnMulti.Text = "\U0001f91d Chơi đa";
            btnMulti.Click += btnMulti_Click;
            // 
            // btnBangxephang
            // 
            btnBangxephang.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnBangxephang.Location = new Point(246, 212);
            btnBangxephang.Name = "btnBangxephang";
            btnBangxephang.Size = new Size(286, 50);
            btnBangxephang.TabIndex = 8;
            btnBangxephang.Text = "🏆 Bảng xếp hạng";
            btnBangxephang.Click += btnBangxephang_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnExit.Location = new Point(246, 299);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(286, 50);
            btnExit.TabIndex = 9;
            btnExit.Text = "❌ Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSingle);
            Controls.Add(btnMulti);
            Controls.Add(btnBangxephang);
            Controls.Add(btnExit);
            Name = "FormGame";
            Text = "FormGame";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSingle;
        private Button btnMulti;
        private Button btnBangxephang;
        private Button btnExit;
    }
}