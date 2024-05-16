using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e) // Add button on web page
        {
            try
            {
                // Checks to see if there are numerals in the boxes.
                if (NilaiTest.Text != "")
                {
                    var Kelompok = "";
                    var Biaya = "";
                    if (double.Parse(NilaiTest.Text.ToString()) >= 91 && double.Parse(NilaiTest.Text.ToString()) <= 100) 
                    {
                        Kelompok = "Kelas A";
                        Biaya = "Rp 800,000";
                    }
                    else if(double.Parse(NilaiTest.Text.ToString()) >= 76 && double.Parse(NilaiTest.Text.ToString()) <= 90)
                    {
                        Kelompok = "Kelas B";
                        Biaya = "Rp 850,000";
                    }
                    else if(double.Parse(NilaiTest.Text.ToString()) >= 60 && double.Parse(NilaiTest.Text.ToString()) <= 75)
                    {
                        Kelompok = "Kelas C";
                        Biaya = "Rp 900,000";
                    }
                    else if(double.Parse(NilaiTest.Text.ToString()) >= 40 && double.Parse(NilaiTest.Text.ToString()) <= 59)
                    {
                        Kelompok = "Kelas D";
                        Biaya = "Rp 950,000";
                    }
                    else
                    {
                        Kelompok = "Kelas E";
                        Biaya = "RP 1,000,000";
                    }
                    HasilLabel.Text = "Kelompok : " + Kelompok + "<br>" + "Biaya : " + Biaya;
                }
            }
            catch (FormatException) // This catches and proclaims that the user must enter only numerals
            {
                HasilLabel.Text = "Input an harus angka !"; // Displayed string if the catch is executed.
            }
        }
    }
}