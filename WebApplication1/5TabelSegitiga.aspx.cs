﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _5TabelSegitiga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e) // Add button on web page
        {
            // Checks to see if there are numerals in the boxes.
            if (Kolom.Text != "")
            {
                HasilLabel.Text += "<table style=\"border: 1px solid black;\" class=\"center\">";
                for (int i = 1; i <= int.Parse(Kolom.Text.ToString()); i++)
                {
                    HasilLabel.Text += "<tr style=\"border: 1px solid black;\">";
                    for (int j = 1; j <= i; j++)
                    {
                        HasilLabel.Text += "<td style=\"border: 1px solid black;\">"
                                            + "Kolom ke-" + j.ToString() + "<br>"
                                            + "</td>";
                    }
                    HasilLabel.Text += "</tr>";
                }
            }
        }
    }
}