using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using Excel = Microsoft.Office.Interop.Excel;

namespace excelEntegrasyonProjesi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=LENOVO-BERIL;Initial Catalog=projelerVT;Integrated Security=True;Trust Server Certificate=True");
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnVTdenOku_Click(object sender, EventArgs e)
        {
            Excel.Application excelUygulama = new Excel.Application();
            excelUygulama.Visible = true;
            Excel.Workbook workbook = excelUygulama.Workbooks.Add(System.Reflection.Missing.Value);
            Excel.Worksheet sheet1 = workbook.Sheets[1];


            string[] basliklar = { "Personal No", "Ad", "Soyad", "Semt", "Þehir" };
            Excel.Range range;
            for(int i=0; i < basliklar.Length; i++)
            {
                range = sheet1.Cells[1, (i + 1)];
                range.Value2 = basliklar[i];
                
            }


            try
            {
                baglanti.Open();
                string sql = "SELECT personalNo, ad, soyad, semt, sehir FROM Personal";
                SqlCommand sqlCommand = new SqlCommand(sql, baglanti);
                Microsoft.Data.SqlClient.SqlDataReader srd = sqlCommand.ExecuteReader();

                while (srd.Read())
                {
                    string pno = srd[0].ToString();
                    string ad = srd[1].ToString();
                    string soyad = srd[2].ToString();
                    string semt = srd[3].ToString();
                    string sehir = srd[4].ToString();
                    richTextBox1.Text = richTextBox1.Text + pno + "  " + ad + "  " + soyad + "  " + semt + "  " + sehir + "\n";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Query sýrasýnda hata oluþtu, hata kodu: SQLREAD01 \n" + ex.ToString());

            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
        }
    }
}
