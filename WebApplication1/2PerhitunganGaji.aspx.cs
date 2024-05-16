using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _2PerhitunganGaji : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e) // Add button on web page
        {
            // Checks to see if there are numerals in the boxes.
            if (Nama.Text != "" && Jabatan.Text != "" && Hari.Text != "" && Lembur.Text != "")
            {
                string Jabatan1 = Jabatan.Text.ToString();
                double Gaji = 0;
                switch (Jabatan1)
                {
                    case "A":
                        Gaji = (double.Parse(Hari.Text.ToString()) * 8 * 75000) + (double.Parse(Lembur.Text.ToString()) * 0);
                        break;
                    case "B":
                        Gaji = (double.Parse(Hari.Text.ToString()) * 8 * 50000) + (double.Parse(Lembur.Text.ToString()) * 25000);
                        break;
                    case "C":
                        Gaji = (double.Parse(Hari.Text.ToString()) * 8 * 25000) + (double.Parse(Lembur.Text.ToString()) * 20000);
                        break;
                    default:
                        Gaji = 0;
                        break;
                }
                HasilLabel.Text = "Gaji " + Nama.Text.ToString() + " Jabatan " + Jabatan.Text.ToString() + " Bulan Ini : Rp " + Gaji.ToString("n");
            }
        }
    }
}