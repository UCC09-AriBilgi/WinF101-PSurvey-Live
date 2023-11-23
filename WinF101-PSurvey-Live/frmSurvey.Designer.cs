namespace WinF101_PSurvey_Live
{
    partial class frmSurvey
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
            tboxQuestion = new TextBox();
            rbtnYes = new RadioButton();
            grpbOption = new GroupBox();
            rbtnNo = new RadioButton();
            rbtnMaybe = new RadioButton();
            btonPrev = new Button();
            btonNext = new Button();
            dgrdQuestions = new DataGridView();
            btonSave = new Button();
            tboxUserID = new TextBox();
            grpbOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrdQuestions).BeginInit();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(762, 462);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // tboxQuestion
            // 
            tboxQuestion.Enabled = false;
            tboxQuestion.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tboxQuestion.Location = new Point(96, 167);
            tboxQuestion.Multiline = true;
            tboxQuestion.Name = "tboxQuestion";
            tboxQuestion.Size = new Size(603, 174);
            tboxQuestion.TabIndex = 1;
            // 
            // rbtnYes
            // 
            rbtnYes.AutoSize = true;
            rbtnYes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnYes.Location = new Point(54, 39);
            rbtnYes.Name = "rbtnYes";
            rbtnYes.Size = new Size(65, 29);
            rbtnYes.TabIndex = 2;
            rbtnYes.TabStop = true;
            rbtnYes.Text = "Evet";
            rbtnYes.UseVisualStyleBackColor = true;
            // 
            // grpbOption
            // 
            grpbOption.Controls.Add(rbtnNo);
            grpbOption.Controls.Add(rbtnMaybe);
            grpbOption.Controls.Add(rbtnYes);
            grpbOption.Location = new Point(96, 338);
            grpbOption.Name = "grpbOption";
            grpbOption.Size = new Size(603, 100);
            grpbOption.TabIndex = 3;
            grpbOption.TabStop = false;
            // 
            // rbtnNo
            // 
            rbtnNo.AutoSize = true;
            rbtnNo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnNo.Location = new Point(441, 39);
            rbtnNo.Name = "rbtnNo";
            rbtnNo.Size = new Size(74, 29);
            rbtnNo.TabIndex = 4;
            rbtnNo.TabStop = true;
            rbtnNo.Text = "Hayır";
            rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnMaybe
            // 
            rbtnMaybe.AutoSize = true;
            rbtnMaybe.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnMaybe.Location = new Point(245, 39);
            rbtnMaybe.Name = "rbtnMaybe";
            rbtnMaybe.Size = new Size(70, 29);
            rbtnMaybe.TabIndex = 3;
            rbtnMaybe.TabStop = true;
            rbtnMaybe.Text = "Belki";
            rbtnMaybe.UseVisualStyleBackColor = true;
            // 
            // btonPrev
            // 
            btonPrev.Location = new Point(12, 239);
            btonPrev.Name = "btonPrev";
            btonPrev.Size = new Size(75, 23);
            btonPrev.TabIndex = 5;
            btonPrev.Text = "Önceki";
            btonPrev.UseVisualStyleBackColor = true;
            // 
            // btonNext
            // 
            btonNext.Location = new Point(713, 239);
            btonNext.Name = "btonNext";
            btonNext.Size = new Size(75, 23);
            btonNext.TabIndex = 6;
            btonNext.Text = "Sonraki";
            btonNext.UseVisualStyleBackColor = true;
            // 
            // dgrdQuestions
            // 
            dgrdQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdQuestions.Location = new Point(96, 11);
            dgrdQuestions.Name = "dgrdQuestions";
            dgrdQuestions.RowTemplate.Height = 25;
            dgrdQuestions.Size = new Size(603, 150);
            dgrdQuestions.TabIndex = 7;
            dgrdQuestions.CellClick += dgrdQuestions_CellClick;
            // 
            // btonSave
            // 
            btonSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btonSave.Location = new Point(96, 462);
            btonSave.Name = "btonSave";
            btonSave.Size = new Size(78, 36);
            btonSave.TabIndex = 8;
            btonSave.Text = "Kayıt";
            btonSave.UseVisualStyleBackColor = true;
            btonSave.Click += btonSave_Click;
            // 
            // tboxUserID
            // 
            tboxUserID.Location = new Point(713, 12);
            tboxUserID.Name = "tboxUserID";
            tboxUserID.Size = new Size(47, 23);
            tboxUserID.TabIndex = 9;
            // 
            // frmSurvey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 497);
            ControlBox = false;
            Controls.Add(tboxUserID);
            Controls.Add(btonSave);
            Controls.Add(dgrdQuestions);
            Controls.Add(btonNext);
            Controls.Add(btonPrev);
            Controls.Add(grpbOption);
            Controls.Add(tboxQuestion);
            Controls.Add(btonClose);
            Name = "frmSurvey";
            Text = "frmSurvey";
            WindowState = FormWindowState.Maximized;
            Load += frmSurvey_Load;
            grpbOption.ResumeLayout(false);
            grpbOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrdQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private TextBox tboxQuestion;
        private RadioButton rbtnYes;
        private GroupBox grpbOption;
        private RadioButton rbtnNo;
        private RadioButton rbtnMaybe;
        private Button btonPrev;
        private Button btonNext;
        private DataGridView dgrdQuestions;
        private Button btonSave;
        private TextBox tboxUserID;
    }
}