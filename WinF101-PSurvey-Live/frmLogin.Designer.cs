namespace WinF101_PSurvey_Live
{
    partial class frmLogin
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
            btonClose = new Button();
            btonLogin = new Button();
            tboxUserPass = new TextBox();
            label2 = new Label();
            tboxUserName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Location = new Point(372, 201);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Çıkış";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // btonLogin
            // 
            btonLogin.Location = new Point(199, 165);
            btonLogin.Name = "btonLogin";
            btonLogin.Size = new Size(75, 23);
            btonLogin.TabIndex = 12;
            btonLogin.Text = "Giriş";
            btonLogin.UseVisualStyleBackColor = true;
            btonLogin.Click += btonLogin_Click;
            // 
            // tboxUserPass
            // 
            tboxUserPass.Location = new Point(199, 91);
            tboxUserPass.MaxLength = 10;
            tboxUserPass.Name = "tboxUserPass";
            tboxUserPass.PasswordChar = '*';
            tboxUserPass.Size = new Size(100, 23);
            tboxUserPass.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 94);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 10;
            label2.Text = "Kullanıcı Şifre";
            // 
            // tboxUserName
            // 
            tboxUserName.Location = new Point(199, 49);
            tboxUserName.Name = "tboxUserName";
            tboxUserName.Size = new Size(190, 23);
            tboxUserName.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 52);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adı";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 236);
            Controls.Add(btonLogin);
            Controls.Add(tboxUserPass);
            Controls.Add(label2);
            Controls.Add(tboxUserName);
            Controls.Add(label1);
            Controls.Add(btonClose);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private Button btonLogin;
        private TextBox tboxUserPass;
        private Label label2;
        private TextBox tboxUserName;
        private Label label1;
    }
}