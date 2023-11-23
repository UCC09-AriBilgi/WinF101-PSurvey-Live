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
    public partial class frmSignUp : Form
    {
        // Tüm uygulama dahilinde geçerli olması için değişgenlerimi burada yaratıyorum
        //string vs_ConnStr = @"Data Source=BILCE;Initial Catalog=Northwind;TrustServerCertificate=True;Persist Security Info=False;Encrypt=False;"; // Connection String : veritabanına bağlanma için
        string vs_ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        string vs_SQLCommand; // SQL Command : SQL tarafın çalışacak SQL Komutları

        string vs_Query; // Sorgulamalarda kullanacağım SQL Kriter cümleciğini tutacak...
        string vs_SQLText; // Genel SQL Sorgulama textini tutacak

        string Mod; // C,U,D Create Update Delete

        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            tboxUserName.Focus();
        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            string vs_SQLInsert = ""; // benim SQL Insert komutumu tutacak

            // yazım öncesi gerekli kontrollerin yapıldığı kabuluyle
            // tboxProductName boş/dolu
            // cbox seçilmiş/seçilmemiş

            vs_SQLInsert = "INSERT INTO datUser (UserName,UserPass) VALUES ('" + tboxUserName.Text.Trim() +"','" + tboxUserPass.Text.Trim() + "')";


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

                        MessageBox.Show("Bilgileriniz veri tabanına başarıyla işlendi...");


                        tboxUserName.Text = "";
                        tboxUserPass.Clear();
                        tboxUserPass2.Clear();

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
