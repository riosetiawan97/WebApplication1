using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _4TabelPersegi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e) // Add button on web page
        {
            // Checks to see if there are numerals in the boxes.
            if (Kolom.Text != "" && Baris.Text != "")
            {
                HasilLabel.Text += "<table style=\"border: 1px solid black;\" class=\"center\">";
                for (int i = 1; i <= int.Parse(Baris.Text.ToString()); i++)
                {
                    HasilLabel.Text += "<tr style=\"border: 1px solid black;\">";
                    for (int j = 1; j <= int.Parse(Kolom.Text.ToString()); j++)
                    {
                        HasilLabel.Text += "<td style=\"border: 1px solid black;\">"
                                            + "Kolom ke-" + j.ToString() + "<br>"
                                            + "Baris ke-" + i.ToString()
                                            + "</td>";
                    }
                    HasilLabel.Text += "</tr>";
                }
            }
        }
        protected void BackButton_Click(object sender, EventArgs e) // Add button on web page
        {
            // Checks to see if there are numerals in the boxes.
            Response.Redirect("Home.aspx");
            //or
            Server.Transfer("Home.aspx");
        }
    }
}