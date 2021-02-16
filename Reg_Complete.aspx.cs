using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Reg_Complete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            int seconds = int.Parse(Label1.Text);
            if (seconds > 0)
                Label1.Text = (seconds - 1).ToString();
            else
                Response.Redirect("Login.aspx");
        }
    }
}