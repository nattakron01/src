using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    public partial class Login : System.Web.UI.Page
    {
        string sql = @"Server=(LocalDB)\MSSQLLocalDB;Initial Catalog=Project_Senior;uid=sa;pwd=temp;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["User_Email"] = "";
            Session["user"] = "";
            Session["status"] = "";
        }

        protected void SignUp_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void Signin_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sql);

            string query = "SELECT * FROM guardian WHERE username = '" + inputUser.Value + "' and password = '" + inputPwd.Value + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                Session["user"] = inputUser.Value.ToLower();
                string query2 = "SELECT * FROM guardian WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query2, con);
                cmd.Parameters.AddWithValue("@username", inputUser.Value);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    string status = "";
                    while (dr.Read())
                    {
                        Session["User_Email"] = dr["email"].ToString();
                        status = dr["status"].ToString();
                        if(status == "ผู้ปกครอง")
                        {
                            Session["status"] = "parent";
                        }
                        else
                        {
                            Session["status"] = "teacher";
                        }
                    }
                }
                con.Close();
                Response.Redirect("Child_List.aspx");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('กรุณาตรวจสอบชื่อผู้ใช้กับรหัสผ่านใหม่')</script>");
            }
        }
    }
}