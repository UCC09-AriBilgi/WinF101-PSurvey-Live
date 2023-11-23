namespace WinF101_PSurvey_Live
{
    partial class frmSignUp
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
            label1 = new Label();
            tboxUserName = new TextBox();
            label2 = new Label();
            tboxUserPass = new TextBox();
            btonClose = new Button();
            btonSave = new Button();
            label3 = new Label();
            tboxUserPass2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // tboxUserName
            // 
            tboxUserName.Location = new Point(141, 15);
            tboxUserName.Name = "tboxUserName";
            tboxUserName.Size = new Size(190, 23);
            tboxUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Şifre";
            // 
            // tboxUserPass
            // 
            tboxUserPass.Location = new Point(141, 57);
            tboxUserPass.MaxLength = 10;
            tboxUserPass.Name = "tboxUserPass";
            tboxUserPass.PasswordChar = '*';
            tboxUserPass.Size = new Size(100, 23);
            tboxUserPass.TabIndex = 3;
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(317, 168);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 4;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // btonSave
            // 
            btonSave.Location = new Point(141, 131);
            btonSave.Name = "btonSave";
            btonSave.Size = new Size(75, 23);
            btonSave.TabIndex = 5;
            btonSave.Text = "Kayıt";
            btonSave.UseVisualStyleBackColor = true;
            btonSave.Click += btonSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 6;
            label3.Text = "Kullanıcı Şifre (Tekrar)";
            // 
            // tboxUserPass2
            // 
            tboxUserPass2.Location = new Point(141, 92);
            tboxUserPass2.MaxLength = 10;
            tboxUserPass2.Name = "tboxUserPass2";
            tboxUserPass2.PasswordChar = '*';
            tboxUserPass2.Size = new Size(100, 23);
            tboxUserPass2.TabIndex = 7;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 203);
            ControlBox = false;
            Controls.Add(tboxUserPass2);
            Controls.Add(label3);
            Controls.Add(btonSave);
            Controls.Add(btonClose);
            Controls.Add(tboxUserPass);
            Controls.Add(label2);
            Controls.Add(tboxUserName);
            Controls.Add(label1);
            Name = "frmSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Kayıt";
            Load += frmSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tboxUserName;
        private Label label2;
        private TextBox tboxUserPass;
        private Button btonClose;
        private Button btonSave;
        private Label label3;
        private TextBox tboxUserPass2;
    }
}