using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_1
{
    public partial class AnotherPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowFromSession_Click(object sender, EventArgs e)
        {
            output.Text = Session["name"].ToString();
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("HelloWorld.aspx");
        }

        protected void ShowFromSession2_Click(object sender, EventArgs e)
        {
            Person p = (Person)Session["Person"];

            output.Text = $"Name: {p.name} <br/> Email: {p.email} <br/> Contact No.: {p.number}";
        }
    }
}