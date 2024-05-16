using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _3PerhitunganLuas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e) // Add button on web page
        {
            // Checks to see if there are numerals in the boxes.
            if (Rumus.Text != "" && Panjang.Text != "")
            {
                double Luas = 0;
                if (Rumus.Text == "Segitiga")
                {
                    Luas = double.Parse(Panjang.Text.ToString()) * double.Parse(Lebar.Text.ToString()) / 2;
                    HasilLabel.Text = "Perhitungan Luas Segitiga" + "<br>" +
                        "Alas = " + Panjang.Text.ToString() + "<br>" +
                        "Tinggi = " + Lebar.Text.ToString() + "<br>" +
                        "Luas = " + Luas.ToString();
                }
                if (Rumus.Text == "Persegi")
                {
                    Luas = double.Parse(Panjang.Text.ToString()) * double.Parse(Lebar.Text.ToString());
                    HasilLabel.Text = "Perhitungan Luas Persegi Panjang" + "<br>" +
                        "Panjang = " + Panjang.Text.ToString() + "<br>" +
                        "Lebar = " + Lebar.Text.ToString() + "<br>" +
                        "Luas = " + Luas.ToString();
                }
                if (Rumus.Text == "Lingkaran")
                {
                    Luas = 3.14 * double.Parse(Panjang.Text.ToString()) * double.Parse(Panjang.Text.ToString());
                    HasilLabel.Text = "Perhitungan Luas Lingkaran" + "<br>" +
                        "Phi = 3,14" + "<br>" +
                        "Radius = " + Panjang.Text.ToString() + "<br>" +
                        "Luas = " + Luas.ToString();
                }
            }
        }
    }
}