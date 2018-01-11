using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace xml_olusturma
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string yol;
        protected void Page_Load(object sender, EventArgs e)
        {
            link.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (XmlWriter xWr = XmlWriter.Create(Server.MapPath("library.xml")))
            {
                xWr.WriteStartDocument();

                xWr.WriteStartElement("Library");


                SqlConnection con = new SqlConnection("Server=den1.mssql5.gear.host;Database=kutuphane;User Id=kutuphane;Password = Wm8Na!iLw5_Q;");
                con.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = con;
                komut.CommandText = "select * from books";
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    xWr.WriteStartElement("List");

                    // ADD FEW ELEMENTS.
                    xWr.WriteElementString("BookName", dr["book_name"].ToString());
                    xWr.WriteElementString("Category", dr["category"].ToString());
                    xWr.WriteElementString("Price", dr["price"].ToString() + " TL");
                    xWr.WriteEndElement();          // CLOSE LIST.
                }

                xWr.WriteEndElement();          // CLOSE LIBRARY.
                xWr.WriteEndDocument();         // END DOCUMENT.

                // FLUSH AND CLOSE.
                xWr.Flush();
                xWr.Close();
            }
            link.Visible = true;
            yol = "http://xml.gearhostpreview.com/library.xml";
        }
    }
}