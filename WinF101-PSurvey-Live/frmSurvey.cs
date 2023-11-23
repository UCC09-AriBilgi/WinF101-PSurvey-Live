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
        string vs_ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        string vs_SQLCommand; // SQL Command : SQL tarafın çalışacak SQL Komutları

        string vs_Query; // Sorgulamalarda kullanacağım SQL Kriter cümleciğini tutacak...
        string vs_SQLText; // Genel SQL Sorgulama textini tutacak
        string vs_SQLSelect;
        string vs_SQLInsert;

        string Mod; // C,U,D Create Update Delete

        DataSet dset; // baştan tanımladım..aşada doldurcam içini

        int vi_QRecordIndex;

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

            BindQuestions();

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
                        dset = new DataSet();

                        adapter.Fill(dset);

                        GlobalClass.QID = (int)dset.Tables[0].Rows[0]["QID"]; // dset ilk kayıdın soru numarasını alıp class a koyuyorum

                        tboxQuestion.Text = dset.Tables[0].Rows[0]["QText"].ToString();
                        // şu an aslında ilk kayıttayım.Önceki butonuna basamamalıyım.

                        lbelQNo.Text += GlobalClass.QID.ToString();

                        btonPrev.Enabled = false;

                        //using (DataSet dset = new DataSet())
                        //{
                        //    adapter.Fill(dset);

                        //}
                    }
                }

            }


        }

        //private void dgrdQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    tboxQuestion.Text = dgrdQuestions.CurrentRow.Cells[1].Value.ToString();
        //}

        private void btonSave_Click(object sender, EventArgs e)
        {
            int vi_Option = 0;
            var frmLogin = new frmLogin();


            vs_SQLInsert = "INSERT INTO datPQA (PID,SurveyID,QID,OptID) VALUES (";

            //vs_SQLInsert += frmLogin.vi_UserID.ToString()
            //+ ",1," + dgrdQuestions.CurrentRow.Cells[0].Value + ",";

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

        private void btonPrev_Click(object sender, EventArgs e)
        {
            if (vi_QRecordIndex >= 0)
            {
                btonNext.Enabled = true;

                tboxQuestion.Text = dset.Tables[0].Rows[vi_QRecordIndex++]["QText"].ToString();

                GlobalClass.QID--;
                
                lbelQNo.Text = "Soru No : " + GlobalClass.QID.ToString();

            }
            else
            {
                btonPrev.Enabled = false;
            }
        }

        private void btonNext_Click(object sender, EventArgs e)
        {
            if (vi_QRecordIndex <= dset.Tables[0].Rows.Count-1)
            {
                btonPrev.Enabled = true;

                tboxQuestion.Text = dset.Tables[0].Rows[vi_QRecordIndex++]["QText"].ToString();
                
                GlobalClass.QID++;
                
                lbelQNo.Text = "Soru No : " + GlobalClass.QID.ToString();
            }
            else
            {
                btonNext.Enabled = false;
            }
        }
    }
}

