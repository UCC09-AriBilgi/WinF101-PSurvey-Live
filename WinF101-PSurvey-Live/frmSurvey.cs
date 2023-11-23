using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinF101_PSurvey_Live
{
    public partial class frmSurvey : Form
    {
        // Tüm uygulama dahilinde geçerli olması için değişgenlerimi burada yaratıyorum
        //string vs_ConnStr = @"Data Source=BILCE;Initial Catalog=Northwind;TrustServerCertificate=True;Persist Security Info=False;Encrypt=False;"; // Connection String : veritabanına bağlanma için
        string vs_ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        string vs_SQLCommand; // SQL Command : SQL tarafın çalışacak SQL Komutları

        string vs_Query; // Sorgulamalarda kullanacağım SQL Kriter cümleciğini tutacak...
        string vs_SQLText; // Genel SQL Sorgulama textini tutacak
        string vs_SQLSelect;
        string vs_SQLInsert;

        string Mod; // C,U,D Create Update Delete

        public frmSurvey()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSurvey_Load(object sender, EventArgs e)
        {
            // 1. tüm sorular okunur
            // 2. ilk soru text box içine geirilir
            // 3. next tusuna basıldığında bir sonraki soruya geçilir
            // 4. prev tusuna basıldığında bir onceki soruya geçilir
            // Not. ilk veya son yayıt durumundaysam ilgili butonlar desaktif olabilir.
            PrepareGrid();
            BindQuestions();


        }
        private void PrepareGrid()
        {
            // Ekrandaki datagrid i ayarlar...

            // Set AutoGenerateColumns --> false
            dgrdQuestions.AutoGenerateColumns = false;

            // Set AllowUser..false...ekrandan grid üzerinden kayıt ekleme yapmasın...benim butonuma mahkum olsun. 
            dgrdQuestions.AllowUserToAddRows = false;
            dgrdQuestions.AllowUserToDeleteRows = false;

            // Set AutoSizeColumnsMode --> Fill -- colonların genişlikleriyle ilgili
            dgrdQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrdQuestions.RowHeadersVisible = false;

            dgrdQuestions.AllowUserToResizeRows = false;

            dgrdQuestions.ReadOnly = true;

            dgrdQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgrdQuestions.ColumnCount = 2;

            // Add columns

            dgrdQuestions.Columns[0].Name = "QID";
            dgrdQuestions.Columns[0].HeaderText = "QuestionID";
            dgrdQuestions.Columns[0].DataPropertyName = "QID";

            dgrdQuestions.Columns[1].Name = "QText";
            dgrdQuestions.Columns[1].HeaderText = "QText";
            dgrdQuestions.Columns[1].DataPropertyName = "QText";

        }
        private void BindQuestions()
        {
            // VT nındaki bilgileri alıp DG içine gömmek için

            vs_SQLCommand = "SELECT * FROM prmQuestion";

            using (SqlConnection connection = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            adapter.Fill(dset);

                            dgrdQuestions.DataSource = dset.Tables[0];





                        }
                    }
                }

            }


        }

        private void dgrdQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxQuestion.Text = dgrdQuestions.CurrentRow.Cells[1].Value.ToString();
        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            int vi_Option=0;
            var frmLogin = new frmLogin();


            vs_SQLInsert = "INSERT INTO datPQA (PID,SurveyID,QID,OptID) VALUES (";

            vs_SQLInsert += frmLogin.vi_UserID.ToString()
                + ",1," + dgrdQuestions.CurrentRow.Cells[0].Value + ",";

            if (rbtnYes.Checked)
            {
                vi_Option = 1;
            }

            if (rbtnMaybe.Checked)
            {
                vi_Option = 2;
            }

            if (rbtnNo.Checked)
            {
                vi_Option = 3;
            }

            vs_SQLInsert = vs_SQLInsert + vi_Option.ToString()
                + ")";


            // =====================

            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(vs_SQLInsert, con))
                {
                    // yani şimdi parametrelerin doldurulma zamanı...

                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Bilgileriniz veri tabanına başarıyla eklendi...");

                    }
                    catch (Exception message)
                    {
                        MessageBox.Show("Hata : " + message.ToString());

                    }
                }

            }

        }

    }
}

