using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Net.Mail;
using System.Net;

namespace Project
{
    public partial class Register : System.Web.UI.Page
    {
        string sql = @"Server=(LocalDB)\MSSQLLocalDB;Initial Catalog=Project_Senior;uid=sa;pwd=temp;Integrated Security=True";
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if(this.IsPostBack)
            {
                pwd_input.Attributes["value"] = pwd_input.Text;
                pwdcon_input.Attributes["value"] = pwdcon_input.Text;
            }
        }

        bool datachecking()
        {
            bool name_status = false, surname_status = false, user_status = false, pwd_status = false, pwdcon_status = false, email_status = false, sta_status = false;

            string input = name_input.Text;
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                name_status = false;
            }
            else
            {
                name_status = true;
            }

            string input2 = surname_input.Text;
            if (string.IsNullOrEmpty(input2) || string.IsNullOrWhiteSpace(input2))
            {
                surname_status = false;
            }
            else
            {
                surname_status = true;
            }

            string user2 = User_input.Text.ToLower();
            if (user2.Length > 3 && user2.Length < 11 && Regex.IsMatch(user2, "^[a-zA-Z0-9]*$") && !string.IsNullOrWhiteSpace(User_input.Text))
            {
                string status1;
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    using (SqlCommand cmd = new SqlCommand("CheckID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", user2);
                        conn.Open();
                        status1 = Convert.ToString(cmd.ExecuteScalar());
                        conn.Close();
                        if (status1 == "TRUE")
                        {
                            user_status = true;
                        }
                        else
                        {
                            user_status = false;
                        }
                    }
                }
            }
            else
            {
                user_status = false;
            }

            if (pwd_input.Text.Length > 5 && pwd_input.Text.Length < 16)
            {
                pwd_status = true;
            }
            else
            {
                pwd_status = false;
            }

            if (pwd_input.Attributes["value"] == pwdcon_input.Attributes["value"])
            {
                pwdcon_status = true;
            }
            else
            {
                pwdcon_status = false;
            }
            bool vaild = IsValidEmail(Email_input.Text.ToLower());

            if (vaild == true)
            {
                string email = Email_input.Text.ToLower();
                string status1;
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    using (SqlCommand cmd = new SqlCommand("CheckEmail", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@email", email);
                        conn.Open();
                        status1 = Convert.ToString(cmd.ExecuteScalar());
                        conn.Close();
                        if (status1 == "TRUE")
                        {
                            email_status = true;
                        }
                        else
                        {
                            email_status = false;
                        }
                    }
                }
            }
            else
            {
                email_status = false;
            }

            if (DropDownList1.SelectedIndex != 0)
            {
                sta_status = true;
            }
            else
            {
                sta_status = false;
            }

            if(name_status == true && surname_status == true && user_status == true && pwdcon_status == true && pwd_status == true && email_status == true && sta_status == true)
            {
                return true;
            }

            return false;
        }

        protected void RegConfirm_Click(object sender, EventArgs e)
        {
            bool pass = datachecking();

            

            if (pass == true)
            {
                Random random = new Random();
                string b = "0123456789";
                int length = 6;
                string ran = "";
                for (int i = 0; i < length; i++)
                {
                    int a = random.Next(b.Length);
                    ran = ran + b.ElementAt(a);
                }

                Session["OTP_code"] = ran;

                string newline = "\r\n";
                string name = name_input.Text, surname = surname_input.Text;
                string email = Email_input.Text; // เมลที่หมาย
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                message.From = new MailAddress("adhdtestsite@gmail.com", "สมัครสมาชิก ADHD Test", System.Text.Encoding.UTF8);
                message.To.Add(email);
                message.Subject = "ถึงคุณ " + name + " " + surname + " - ADHD Test"; ;
                message.SubjectEncoding = System.Text.Encoding.UTF8;
                message.Body = "ขอบคุณท่าน " + name + " " + surname    + " ที่ให้ความสนใจระบบประเมินอาการสมาธิสั้นของเรา" + newline + newline + "รหัส OTP ของคุณ : " + ran;
                message.BodyEncoding = System.Text.Encoding.UTF8;

                smtp.Port = 587;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential("adhdtestsite@gmail.com", "W3139w3139");
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                try
                {
                    
                }
                catch (Exception ex)
                {

                }
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "none","<script>$('#OTP').modal('show');</script>", false);
            }
            else
            {
                string script = "alert(\"กรุณากรอกข้อมูลให้ถูกต้อง\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedIndex == 1)
            {
                SchoolIp.Enabled = false;
                StatusCheck.Visible = false;
                SchoolIp.Visible = false;
                schoolTag.Visible = false;
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                SchoolIp.Enabled = true;
                SchoolIp.Visible = true;
                StatusCheck.Visible = false;
                schoolTag.Visible = true;
            }
            else
            {
                StatusCheck.Visible = true;
                SchoolIp.Visible = false;
                schoolTag.Visible = false;
            }
        }

        protected void Name_Checked(object sender, EventArgs e)
        {
            string input = name_input.Text;
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                NameEmpty.Visible = true;
            }
            else
            {
                NameEmpty.Visible = false;
            }
        }

        protected void User_input_TextChanged(object sender, EventArgs e)
        {
            string user2 = User_input.Text.ToLower();
            if (user2.Length > 3 && Regex.IsMatch(user2, "^[a-zA-Z0-9]*$") && !string.IsNullOrWhiteSpace(User_input.Text))
            {
                UserEmpty.Visible = false;
                string status1;
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    using (SqlCommand cmd = new SqlCommand("CheckID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", user2);
                        conn.Open();
                        status1 = Convert.ToString(cmd.ExecuteScalar());
                        conn.Close();
                        if (status1 == "TRUE")
                        {
                            UserExist.Visible = false;
                        }
                        else
                        {
                            UserExist.Visible = true;
                        }
                    }
                }
            }
            else
            {
                UserEmpty.Visible = true;
            }
        }

        protected void surname_input_TextChanged(object sender, EventArgs e)
        {
            string input = surname_input.Text;
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                SurnameEmpty.Visible = true;
            }
            else
            {
                SurnameEmpty.Visible = false;
            }
        }

        protected void pwd_input_TextChanged(object sender, EventArgs e)
        {
            if (pwd_input.Text.Length > 5)
            {
                PwdEmpty.Visible = false;
                PwdCondition.Visible = false;
            }
            else
            {
                PwdEmpty.Visible = false;
                PwdCondition.Visible = true;
            }
        }

        protected void pwdcon_input_TextChanged(object sender, EventArgs e)
        {
            if(pwd_input.Attributes["value"] == pwdcon_input.Attributes["value"])
            {
                PwdconCondition.Visible = false;
                PwdconEmpty.Visible = false;
            }
            else
            {
                PwdconCondition.Visible = true;
                PwdconEmpty.Visible = false;
            }
        }

        bool IsValidEmail(string email)
{
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        protected void Email_input_TextChanged(object sender, EventArgs e)
        {
            bool vaild = IsValidEmail(Email_input.Text.ToLower());

            if (vaild == true)
            {
                EmailCondition.Visible = false;
                string email = Email_input.Text.ToLower();
                string status1;
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    using (SqlCommand cmd = new SqlCommand("CheckEmail", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@email", email);
                        conn.Open();
                        status1 = Convert.ToString(cmd.ExecuteScalar());
                        conn.Close();
                        if (status1 == "TRUE")
                        {
                            EmailCheck.Visible = false;
                        }
                        else
                        {
                            EmailCheck.Visible = true;
                        }
                    }
                }
            }
            else
            {
                EmailCheck.Visible = false;
                EmailCondition.Visible = true;
            }
        }

        protected void OTP_Resent_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string b = "0123456789";
            int length = 6;
            string ran = "";
            for (int i = 0; i < length; i++)
            {
                int a = random.Next(b.Length);
                ran = ran + b.ElementAt(a);
            }

            Session["OTP_code"] = ran;

            string name = name_input.Text, surname = surname_input.Text;
            string email = Email_input.Text; // เมลที่หมาย
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            message.From = new MailAddress("adhdtestsite@gmail.com", "สมัครสมาชิก ADHD Test", System.Text.Encoding.UTF8);
            message.To.Add(email);
            message.Subject = "ถึงคุณ " + name + " " + surname + " - ADHD Test";
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Body = "รหัส OTP ใหม่ของคุณ : " + ran;
            message.BodyEncoding = System.Text.Encoding.UTF8;

            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("adhdtestsite@gmail.com", "W3139w3139");
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {

            }
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#OTP').modal('show')", true);
        }

        protected void OTP_confirm_Click(object sender, EventArgs e)
        {
            string OTP_confirm = Session["OTP_code"].ToString();

            if (OTP_Input.Text == OTP_confirm)
            {
                SqlConnection con = new SqlConnection(sql);

                string query = "INSERT INTO guardian(name,surname,username,password,email,status,school_name) VALUES(@name,@surname,@user,@Pwd,@Email,@status,@school_name)";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.Parameters.AddWithValue("@name", name_input.Text);
                cmd.Parameters.AddWithValue("@surname", surname_input.Text);
                cmd.Parameters.AddWithValue("@user", User_input.Text);
                cmd.Parameters.AddWithValue("@Pwd", pwd_input.Text);
                cmd.Parameters.AddWithValue("@Email", Email_input.Text);
                cmd.Parameters.AddWithValue("@status", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@school_name", SchoolIp.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                Response.Redirect("Reg_Complete.aspx");

            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('รหัส OTP ไม่ถูกต้องหากไม่พบรหัส OTP กรุณากดปุ่มส่งรหัส OTP ใหม่หรือเช็ค Email ของท่านใหม่อีกครั้ง')</script>");
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#OTP').modal('show')", true);
            }
        }
    }
}
