using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WinF101_PSurvey_Live
{
    public partial class frmLogin : Form
    {
        // Tüm uygulama dahilinde geçerli olması için değişgenlerimi burada yaratıyorum
        //string vs_ConnStr = @"Data Source=BILCE;Initial Catalog=Northwind;TrustServerCertificate=True;Persist Security Info=False;Encrypt=False;"; // Connection String : veritabanına bağlanma için
        string vs_ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        string vs_SQLCommand; // SQL Command : SQL tarafın çalışacak SQL Komutları

        string vs_Query; // Sorgulamalarda kullanacağım SQL Kriter cümleciğini tutacak...
        string vs_SQLText; // Genel SQL Sorgulama textini tutacak
        string vs_SQLSelect;

        string Mod; // C,U,D Create Update Delete

        public int vi_UserID = 0; // tüm programda gecerli olacak

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btonLogin_Click(object sender, EventArgs e)
        {
            string vs_SQLSelect = ""; // benim SQL Select komutumu tutacak

            // yazım öncesi gerekli kontrollerin yapıldığı kabuluyle
            // tboxProductName boş/dolu
            // cbox seçilmiş/seçilmemiş

            vs_SQLSelect = "SELECT UserID FROM datUSER WHERE UserName='" + tboxUserName.Text.Trim() + "' AND UserPass='" + tboxUserPass.Text.Trim() + "'";


            try
            {

                using (SqlConnection connection = new SqlConnection(vs_ConnStr))
                {
                    using (SqlCommand command = new SqlCommand(vs_SQLSelect, connection))
                    {
                        command.CommandType = CommandType.Text;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            using (DataSet dset = new DataSet())
                            {
                                adapter.Fill(dset);

                                //dgrdProducts.DataSource = dset.Tables[0];

                                if (dset.Tables[0].Rows.Count > 0) // bir kayıt gelmiştir
                                {

                                    // ilk login ekranından öğrendiğim UserID yi global bir yerde tutup...anket kayıt edilirken elle manuel yazmış olduğumuz PID=1 yazmıştık....PID=2 yapmak istiyorum.

                                    vi_UserID = Convert.ToInt32(dset.Tables[0].Rows[0]["UserID"]);

                                    frmMain frmMain = new frmMain();

                                    this.Hide(); // Login formunu kapatmak yerine görünürlüğünü kapatıyorum.
                                    frmSurvey frmSurvey = new frmSurvey();
                                    // içine gizli kullanıcı no yu yerleştirecem
                                    



                                    frmMain.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen giriş kayıtlarınızı kontrol ediniz...");
                                }

                            }
                        }
                    }

                }

            }
            catch (Exception message)
            {
                MessageBox.Show("Hata : " + message.ToString());

            }




        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
