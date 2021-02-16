using System;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Project
{
    public partial class Child_List : System.Web.UI.Page
    {
        string sql = @"Server=(LocalDB)\MSSQLLocalDB;Initial Catalog=Project_Senior;uid=sa;pwd=temp;Integrated Security=True";

        void Set_False(string code)
        {
            SqlConnection con = new SqlConnection(sql);
            string query = "UPDATE child_activation SET activation = '0' WHERE invitecode = '" + code + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        void code_check()
        {
            SqlConnection con = new SqlConnection(sql);
            string read = "SELECT * FROM child_activation";
            SqlCommand cmdr = new SqlCommand(read, con);
            con.Open();
            using (SqlDataReader dr = cmdr.ExecuteReader())
            {
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        //Set Expired
                        if(dr.GetBoolean(dr.GetOrdinal("activation")) == true)
                        {
                            DateTime expired = dr.GetDateTime(dr.GetOrdinal("activate_date"));
                            DateTime now = DateTime.Now;
                            string code = dr["invitecode"].ToString();
                            if (now > expired)
                            {
                                Set_False(code);
                            }
                        }
                    }
                }
            }

            con.Close();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            code_check();
            if (!this.IsPostBack)
            {
                DropDownList1.Items.Add("เลือกปี");
                DropDownList2.Items.Add("เลือกเดือน");
                DropDownList2.Items.Add("มกราคม");
                DropDownList2.Items.Add("กุมภาพันธ์");
                DropDownList2.Items.Add("มีนาคม");
                DropDownList2.Items.Add("เมษายน");
                DropDownList2.Items.Add("พฤษภาคม");
                DropDownList2.Items.Add("มิถุนายน");
                DropDownList2.Items.Add("กรกฎาคม");
                DropDownList2.Items.Add("สิงหาคม");
                DropDownList2.Items.Add("กันยายน");
                DropDownList2.Items.Add("ตุลาคม");
                DropDownList2.Items.Add("พฤศจิกายน");
                DropDownList2.Items.Add("ธันวาคม");
                DropDownList3.Items.Add("เลือกวัน");

                string date = DateTime.Now.ToString("yyyy", new CultureInfo("th-TH"));

                for (int i = 7; i < 13; i++)
                {
                    int year = int.Parse(date) - i;

                    DropDownList1.Items.Add(year.ToString());
                }
            }
        }

        string getusername(string child_id)
        {
            string user = "";
            string query = "SELECT * FROM guardian WHERE email IN (SELECT guardian_email FROM guardian_child WHERE child_child_id = '" + child_id + "')";
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        user = dr["username"].ToString();
                    }
                }
            }
            con.Close();

            return user;
        }

        void code_gen(string ran)
        {
            DateTime now = DateTime.Now;
            DateTime today = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
            DateTime expired = today.AddDays(1);

            string query = "INSERT INTO child_activation(invitecode,create_date,activation,activate_date) VALUES(@code,getdate(),@active,@expired)";
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@code", ran);
            cmd.Parameters.AddWithValue("@Cdate", today);
            cmd.Parameters.AddWithValue("@active", 1);
            cmd.Parameters.AddWithValue("@expired", expired);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        void guardian_child(string email , string id)
        {
            SqlConnection con = new SqlConnection(sql);
            string query = "INSERT INTO guardian_child(guardian_email,child_child_id) VALUES(@email,@id)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Create_Click(object sender, EventArgs e)
        {
            string name = Child_nameIp.Text, surname = Child_SurnameIp.Text;

            bool pass = false;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname))
            {
                pass = true;
            }

            if (pass == true)
            {
                int day = DropDownList3.SelectedIndex, year = int.Parse(DropDownList1.SelectedItem.Text);
                int mouth = 0;
                if (DropDownList2.SelectedIndex == 1)
                {
                    mouth = 1;
                }
                else if (DropDownList2.SelectedIndex == 2)
                {
                    mouth = 2;
                }
                else if (DropDownList2.SelectedIndex == 3)
                {
                    mouth = 3;
                }
                else if (DropDownList2.SelectedIndex == 4)
                {
                    mouth = 4;
                }
                else if (DropDownList2.SelectedIndex == 5)
                {
                    mouth = 5;
                }
                else if (DropDownList2.SelectedIndex == 6)
                {
                    mouth = 6;
                }
                else if (DropDownList2.SelectedIndex == 7)
                {
                    mouth = 7;
                }
                else if (DropDownList2.SelectedIndex == 8)
                {
                    mouth = 8;
                }
                else if (DropDownList2.SelectedIndex == 9)
                {
                    mouth = 9;
                }
                else if (DropDownList2.SelectedIndex == 10)
                {
                    mouth = 10;
                }
                else if (DropDownList2.SelectedIndex == 11)
                {
                    mouth = 11;
                }
                else if (DropDownList2.SelectedIndex == 12)
                {
                    mouth = 12;
                }

                try
                {
                    string date = day + "/" + mouth + "/" + year;
                    DateTime birthday = Convert.ToDateTime(date);
                    string Email = Session["User_Email"].ToString();
                    Random random = new Random();
                    string b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    string ran = "";
                    for (int i = 0; i < 6; i++)
                    {
                        int a = random.Next(b.Length);
                        ran = ran + b.ElementAt(a);
                    }

                    code_gen(ran);

                    SqlConnection con = new SqlConnection(sql);
                    string query = "INSERT INTO child(child_id,name,surname,birthday,gender,child_activation_invitecode,status) VALUES(NEXT VALUE FOR DBO.NextVal,@name,@surname,@birth,@gender,@code,@status)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@birth", birthday);

                    if (RadioMale.Checked)
                    {
                        cmd.Parameters.AddWithValue("@gender", RadioMale.Text.Trim());
                    }
                    else if (RadioFemale.Checked)
                    {
                        cmd.Parameters.AddWithValue("@gender", RadioFemale.Text.Trim());

                    }
                    cmd.Parameters.AddWithValue("@code", ran);
                    cmd.Parameters.AddWithValue("@status", 1);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    

                    string child_id = "", user_status = "";
                    user_status = get_userStatus();

                    SqlCommand cmd3 = new SqlCommand("SELECT TOP 1 * FROM child ORDER BY child_id DESC", con);
                    con.Open();
                    using (SqlDataReader dr = cmd3.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                child_id = dr.GetInt32(dr.GetOrdinal("child_id")).ToString();
                            }
                        }
                    }
                    con.Close();

                    guardian_child(Email,child_id);

                    if(user_status == "ผู้ปกครอง")
                    {
                        string textsend = Session["user"] + "_" + name + " " + Session["user"] + " " + child_id + " " + "SP" + " " + "true";
                        string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                        using (TextWriter writer = new StreamWriter(_filePath + "/Group_List.txt", true))
                        {
                            writer.WriteLine(textsend);
                        }
                    }
                    else
                    {
                        string textsend = Session["user"] + "_" + name + " " + Session["user"] + " " + child_id + " " + "ST" + " " + "true";
                        string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                        using (TextWriter writer = new StreamWriter(_filePath + "/Group_List.txt", true))
                        {
                            writer.WriteLine(textsend);
                        }
                    }
                    

                    Response.Redirect("Child_List.aspx");
                }
                catch
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('กรุณากรอกข้อมูลให้ถูกต้อง')</script>");
                    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#Child_Create').modal('show')", true);
                }
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('กรุณากรอกข้อมูลให้ถูกต้อง')</script>");
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#Child_Create').modal('show')", true);
            }
        }

        bool code_exist(string code)
        {
            SqlConnection con = new SqlConnection(sql);
            string query = "SELECT * FROM child_activation WHERE invitecode = '" + code + "' AND activation = '0'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return false;
            }
            return true;
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            SqlConnection con = new SqlConnection(sql);
            
            string name = ((Label)e.Item.FindControl("nameLabel")).Text;
            string surname = ((Label)e.Item.FindControl("surnameLabel")).Text;
            string Tid = "";
            string queryy = "SELECT TOP 1 * FROM child WHERE name = '" + name + "' AND surname = '" + surname + "'";
            SqlCommand getid = new SqlCommand(queryy, con);
            con.Open();
            SqlDataReader dr = getid.ExecuteReader();
            if(dr.HasRows)
            {
                if(dr.Read())
                {
                    Tid = dr["child_id"].ToString();
                }
            }
            con.Close();
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            string child_id = "", Group_name = "", status = "", user = "", active = "" , group = "";
            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split();
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (i == words.Length - 1)
                        {
                            break;
                        }

                        if (i % 5 == 0)
                        { 
                            string userget = getusername(Tid);
                            group = userget + "_" + name;
                            if (Session["user"].ToString() == words[i + 1] && group == words[i])
                            {
                                Session["group"] = group;
                                child_id = words[i + 2];
                                status = words[i + 3];
                                user = words[i + 1];
                                active = words[i + 4];
                                break;
                            }
                            child_id = "";
                        }
                    }

                    if(child_id != "")
                    {
                        break;
                    }
                }
            }

            

            string query = "SELECT * FROM child WHERE child_id = '" + child_id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Session["child_id"] = child_id;
                Session["user2"] = Session["user"];
                Session["child_name"] = name;
                Session["child_surname"] = surname;
                Session["User_Email2"] = Session["User_Email"].ToString();
                if (e.CommandName == "Question")
                {
                    if (active == "true")
                    {
                        Session["Report_Check_status"] = Session["status"].ToString();
                        Response.Redirect("questionnaire.aspx");
                    }
                }
                else if (e.CommandName == "Score")
                {
                    if (Session["status"].ToString() == "parent")
                    {
                        Response.Redirect("Parent_graph.aspx");
                    }
                    else
                    {
                        Response.Redirect("Teacher_Graph.aspx");
                    }
                }
                else if (e.CommandName == "Gen")
                {
                    string invitecode = ((Label)e.Item.FindControl("invitecodeLabel")).Text;

                    if (status == "SP" || status == "ST")
                    {
                        string stop = "N";
                        while (stop != "Y")
                        {
                            Random random = new Random();
                            string b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                            string ran = "";
                            for (int i = 0; i < 6; i++)
                            {
                                int a = random.Next(b.Length);
                                ran = ran + b.ElementAt(a);
                            }

                            bool check = code_exist(ran);

                            if (check == true)
                            {
                                code_gen(ran);
                                string create_code = "UPDATE child SET child_activation_invitecode = '" + ran + "' WHERE child_id = '" + child_id + "'";
                                string expired = "UPDATE child_activation SET activation = '0' WHERE invitecode = '" + invitecode + "'";
                                SqlCommand code = new SqlCommand(create_code, con);
                                SqlCommand exp = new SqlCommand(expired, con);
                                con.Open();
                                code.ExecuteNonQuery();
                                exp.ExecuteNonQuery();
                                con.Close();
                                stop = "Y";
                            }
                        }
                        Response.Redirect("Child_List.aspx");
                    }
                    else
                    {
                        Response.Write("<script LANGUAGE='JavaScript' >alert('ท่านไม่สามารถสร้าง invitecode ได้เนื่องจากท่านไม่ใช้คนที่สร้างเด็กคนนี้ขึ้นมา')</script>");
                    }


                }
                else if (e.CommandName == "Disable")
                {
                    string confirmValue = Request.Form["confirm_value"];
                    if (confirmValue == "Yes")
                    {
                        try
                        {
                            con.Open();

                            using (SqlCommand Disable_child = new SqlCommand("UPDATE child SET status = '0' WHERE child_id = '" + child_id + "'", con))
                            {
                                Disable_child.ExecuteNonQuery();
                            }

                            var oldLines = System.IO.File.ReadAllLines(_filePath + "/Group_List.txt");
                            var newLines = oldLines.Where(line => !line.Contains(child_id));
                            System.IO.File.WriteAllLines(_filePath + "/Group_List.txt", newLines);

                            string textsend = Group_name + " " + Session["user"] + " " + child_id + " " + status + " False";
                            using (TextWriter writer = new StreamWriter(_filePath + "/Group_List.txt", true))
                            {
                                writer.WriteLine(textsend);
                            }

                            con.Close();
                            Response.Redirect("Child_List.aspx");
                        }
                        catch
                        {

                        }
                    }
                }
            }
            
        }

        bool code_expired(string code)
        {
            SqlConnection con = new SqlConnection(sql);
            string query = "SELECT * FROM child_activation WHERE invitecode = '" + code + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            using(SqlDataReader dr = cmd.ExecuteReader())
            {
                if(dr.HasRows)
                {
                    if(dr.Read())
                    {
                        if(dr.GetBoolean(dr.GetOrdinal("activation")) == false)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        string get_userStatus()
        {
            SqlConnection con = new SqlConnection(sql);

            string status = "";
            string query = "SELECT * FROM guardian WHERE username = '" + Session["user"] + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        status = dr["status"].ToString();
                    }
                }
            }

            return status;
        }

        protected void Create2_Click(object sender, EventArgs e)
        {
            bool pass = code_expired(TextBox1.Text);

            if (pass == true)
            {
                SqlConnection con = new SqlConnection(sql);

                string query = "SELECT * FROM child WHERE child_activation_invitecode = '" + TextBox1.Text.Trim() + "'";
                string query2 = "INSERT INTO child(child_id,name,surname,birthday,gender,child_activation_invitecode,status) VALUES(NEXT VALUE FOR DBO.NextVal,@name,@surname,@birth,@gender,@code,@status)";

                string name = "", surname = "", gender = "", child_id = "";
                DateTime birthday = DateTime.Now;

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            child_id = dr["child_id"].ToString();
                            name = dr["name"].ToString();
                            surname = dr["surname"].ToString();
                            birthday = dr.GetDateTime(dr.GetOrdinal("birthday"));
                            gender = dr["gender"].ToString();
                        }
                    }
                }
                con.Close();

                SqlCommand cmd2 = new SqlCommand(query2, con);

                cmd2.Parameters.AddWithValue("@name", name);
                cmd2.Parameters.AddWithValue("@surname", surname);
                cmd2.Parameters.AddWithValue("@birth", birthday);
                cmd2.Parameters.AddWithValue("@gender", gender);
                cmd2.Parameters.AddWithValue("code", "-");
                cmd2.Parameters.AddWithValue("@status", 1);

                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();


                string child_id2 = "", user_status = "";
                user_status = get_userStatus();

                SqlCommand cmd3 = new SqlCommand("SELECT TOP 1 * FROM child ORDER BY child_id DESC", con);
                con.Open();
                using (SqlDataReader dr = cmd3.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            child_id2 = dr.GetInt32(dr.GetOrdinal("child_id")).ToString();
                        }
                    }
                }
                con.Close();

                guardian_child(Session["User_Email"].ToString(), child_id2);

                string codeuser = getusername(child_id);

                string textsend = codeuser + "_" + name + " " + Session["user"] + " " + child_id2 + " " + user_status + " true";
                string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                using (TextWriter writer = new StreamWriter(_filePath + "/Group_List.txt", true))
                {
                    writer.WriteLine(textsend);
                }

                Response.Redirect("Child_List.aspx");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('invitecode ไม่สามารถใช้งานได้เนื่องจากหมดอายุการใช้งานแล้ว')</script>");
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = int.Parse(DropDownList1.SelectedItem.Value) - 543;
            if (DropDownList2.SelectedItem.Value == "กุมภาพันธ์")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("เลือกวัน");
                if (year % 4 == 0)
                {
                    for (int i = 1; i < 30; i++)
                    {
                        DropDownList3.Items.Add(i.ToString());
                    }
                }
                else
                {
                    for (int i = 1; i < 29; i++)
                    {
                        DropDownList3.Items.Add(i.ToString());
                    }
                }
            }
            else
            {
                DropDownList3.Items.Clear();
                string month = DropDownList2.SelectedItem.Text;
                DropDownList3.Items.Add("เลือกวัน");
                if (month == "มกราคม" || month == "มีนาคม" || month == "พฤษภาคม" || month == "กรกฎาคม" || month == "สิงหาคม" || month == "ตุลาคม" || month == "ธันวาคม")
                {
                    for (int i = 1; i < 32; i++)
                    {
                        DropDownList3.Items.Add(i.ToString());
                    }
                }
                else if (month == "เมษายน" || month == "มิถุนายน" || month == "กันยายน" || month == "พฤศจิกายน")
                {
                    for (int i = 1; i < 31; i++)
                    {
                        DropDownList3.Items.Add(i.ToString());
                    }
                }
            }
            DropDownList3.Enabled = true;
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#Child_Create').modal('show')", true);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("เลือกเดือน");
            DropDownList2.Items.Add("มกราคม");
            DropDownList2.Items.Add("กุมภาพันธ์");
            DropDownList2.Items.Add("มีนาคม");
            DropDownList2.Items.Add("เมษายน");
            DropDownList2.Items.Add("พฤษภาคม");
            DropDownList2.Items.Add("มิถุนายน");
            DropDownList2.Items.Add("กรกฎาคม");
            DropDownList2.Items.Add("สิงหาคม");
            DropDownList2.Items.Add("กันยายน");
            DropDownList2.Items.Add("ตุลาคม");
            DropDownList2.Items.Add("พฤศจิกายน");
            DropDownList2.Items.Add("ธันวาคม");

            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("เลือกวัน");

            DropDownList2.Enabled = true;
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#Child_Create').modal('show')", true);
        }
    }
}