using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;

namespace Project
{
    public partial class questionnaire : System.Web.UI.Page
    {
        string sql = @"Server=(LocalDB)\MSSQLLocalDB;Initial Catalog=Project_Senior;uid=sa;pwd=temp;Integrated Security=True";
        string query = "INSERT INTO guardian_doq_naire(do_ID,child_child_id,guardian_email,question_q_id,dodate,score) VALUES(NEXT VALUE FOR DBO.NextVal2,@Cid,@email,@Qid,@date,@score)";

        void question_fill()
        {
            try
            {
                SqlConnection con = new SqlConnection(sql);
                string query2 = "SELECT TOP 26 * FROM guardian_doq_naire WHERE child_child_id = '" + Session["child_id"] + "' ORDER BY Do_ID DESC";

                con.Open();
                SqlCommand cmd = new SqlCommand(query2, con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            date1.Text = dr.GetDateTime(dr.GetOrdinal("dodate")).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
                            date2.Text = dr.GetDateTime(dr.GetOrdinal("dodate")).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
                            date3.Text = dr.GetDateTime(dr.GetOrdinal("dodate")).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));

                            //Q1 -> Q9
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 1 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 1)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q111.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q112.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q113.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q114.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 2)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q121.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q122.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q123.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q124.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 3)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q131.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q132.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q133.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q134.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 4)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q141.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q142.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q143.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q144.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 5)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q151.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q152.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q153.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q154.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 6)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q161.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q162.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q163.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q164.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 7)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q171.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q172.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q173.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q174.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 8)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q181.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q182.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q183.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q184.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 9)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q191.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q192.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q193.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q194.Attributes.Add("class", "radio");
                                    }
                                }
                            }
                            //End IF Q1 -> Q9

                            //Q19 -> Q26
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 19)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q311.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q312.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q313.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q314.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 20)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q321.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q322.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q323.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q324.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 21)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q331.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q332.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q333.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q334.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 22)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q341.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q342.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q343.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q344.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 23)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q351.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q352.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q353.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q354.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 24)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q361.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q362.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q363.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q364.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 25)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q371.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q372.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q373.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q374.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 26)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q381.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q382.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q383.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q384.Attributes.Add("class", "radio");
                                    }
                                }
                                //End IF Q19 -> Q26
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 10)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q211.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q212.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q213.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q214.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 11)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q221.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q222.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q223.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q224.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 12)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q231.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q232.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q233.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q234.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 13)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q241.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q242.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q243.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q244.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 14)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q251.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q252.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q253.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q254.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 15)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q261.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q262.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q263.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q264.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 16)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q271.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q272.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q273.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q274.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 17)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q281.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q282.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q283.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q284.Attributes.Add("class", "radio");
                                    }
                                }

                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 18)
                                {
                                    if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                    {
                                        Q291.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                    {
                                        Q292.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                    {
                                        Q293.Attributes.Add("class", "radio");
                                    }
                                    else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                    {
                                        Q294.Attributes.Add("class", "radio");
                                    }
                                }
                                //End IF Q1 -> Q9
                            }

                        }
                    }
                }
                con.Close();
            }
            catch
            {

            }
        }

        //Inattension Question
        void Q11(DateTime date)
        {
            string ID = Session["child_id"].ToString();
            string user_email = Session["User_Email2"].ToString();
            int Child_id = int.Parse(ID);
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            if (Q111.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 1);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q112.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 1);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q113.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 1);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q114.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 1);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q12(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q121.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 2);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q122.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 2);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q123.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 2);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q124.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 2);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q13(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();


            if (Q131.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 3);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q132.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 3);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q133.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 3);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q134.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 3);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q14(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString()); ;
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q141.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 4);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q142.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 4);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q143.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 4);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q144.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 4);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q15(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q151.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 5);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q152.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 5);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q153.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 5);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q154.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 5);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q16(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q161.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 6);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q162.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 6);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q163.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 6);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q164.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 6);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q17(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q171.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 7);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q172.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 7);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q173.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 7);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q174.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 7);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q18(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q181.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 8);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q182.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 8);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q183.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 8);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q184.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 8);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q19(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q191.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 9);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q192.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 9);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q193.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 9);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q194.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 9);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        //Inattension Question - End

        //Hyperactive Question
        void Q21(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            string ID = Session["child_id"].ToString();
            int Child_id = int.Parse(ID);
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            if (Q211.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 10);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q212.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 10);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q213.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 10);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q214.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 10);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q22(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q221.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 11);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q222.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 11);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q223.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 11);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q224.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 11);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q23(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q231.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 12);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q232.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 12);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q233.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 12);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q234.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 12);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q24(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q241.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 13);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q242.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 13);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q243.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 13);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q244.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 13);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q25(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q251.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 14);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q252.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 14);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q253.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 14);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q254.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 14);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q26(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q261.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 15);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q262.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 15);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q263.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 15);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q264.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 15);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q27(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q271.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 16);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q272.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 16);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q273.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 16);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q274.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 16);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q28(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q281.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 17);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q282.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 17);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q283.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 17);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q284.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 17);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q29(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q291.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 18);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q292.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 18);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q293.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 18);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q294.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 18);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        //Hyperactive Question - End

        //Disorder Question
        void Q31(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            string ID = Session["child_id"].ToString();
            int Child_id = int.Parse(ID);
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            if (Q311.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 19);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q312.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 19);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q313.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 19);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q314.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 19);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q32(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q321.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 20);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q322.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 20);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q323.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 20);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q324.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 20);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q33(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q331.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 21);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q332.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 21);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q333.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 21);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q334.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 21);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q34(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q341.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 22);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q342.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 22);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q343.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 22);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q344.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 22);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q35(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q351.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 23);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q352.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 23);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q353.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 23);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q354.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 23);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q36(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q361.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 24);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q362.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 24);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q363.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 24);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q364.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 24);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q37(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q371.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 25);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q372.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 25);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q373.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 25);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q374.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 25);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void Q38(DateTime date)
        {
            string user_email = Session["User_Email2"].ToString();
            long Child_id = long.Parse(Session["child_id"].ToString());
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            if (Q381.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 26);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q382.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 26);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 1);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q383.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 26);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 2);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            else if (Q384.Checked)
            {
                cmd.Parameters.AddWithValue("@Qid", 26);
                cmd.Parameters.AddWithValue("@Cid", Child_id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@score", 3);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        //Disorder Question - End

        void score_calculation()
        {
            string dt = DateTime.Now.ToString("dd/MM/yyyy", new CultureInfo("th-TH"));
            DateTime date = Convert.ToDateTime(dt.ToString(), new CultureInfo("th-TH"));

            //Inattension Question
            Q11(date); Q12(date); Q13(date); Q14(date); Q15(date); Q16(date); Q17(date); Q18(date); Q19(date);

            //Hyperactive Question
            Q21(date); Q22(date); Q23(date); Q24(date); Q25(date); Q26(date); Q27(date); Q28(date); Q29(date);

            //Disorder Question
            Q31(date); Q32(date); Q33(date); Q34(date); Q35(date); Q36(date); Q37(date); Q38(date);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["child_name"] + " " + Session["child_surname"];
            question_fill();
            name1.Text = name;
            name2.Text = name;
            name3.Text = name;
        }

        bool Q1_Check()
        {
            //Check Radio_Checked
            bool Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19;
            if (Q111.Checked || Q112.Checked || Q113.Checked || Q114.Checked)
            {
                Q11 = true;
            }
            else
            {
                Q11 = false;
            }

            if (Q121.Checked || Q122.Checked || Q123.Checked || Q124.Checked)
            {
                Q12 = true;
            }
            else
            {
                Q12 = false;
            }

            if (Q131.Checked || Q132.Checked || Q133.Checked || Q134.Checked)
            {
                Q13 = true;
            }
            else
            {
                Q13 = false;
            }

            if (Q141.Checked || Q142.Checked || Q143.Checked || Q144.Checked)
            {
                Q14 = true;
            }
            else
            {
                Q14 = false;
            }

            if (Q151.Checked || Q152.Checked || Q153.Checked || Q154.Checked)
            {
                Q15 = true;
            }
            else
            {
                Q15 = false;
            }

            if (Q161.Checked || Q162.Checked || Q163.Checked || Q164.Checked)
            {
                Q16 = true;
            }
            else
            {
                Q16 = false;
            }

            if (Q171.Checked || Q172.Checked || Q173.Checked || Q174.Checked)
            {
                Q17 = true;
            }
            else
            {
                Q17 = false;
            }

            if (Q181.Checked || Q182.Checked || Q183.Checked || Q184.Checked)
            {
                Q18 = true;
            }
            else
            {
                Q18 = false;
            }

            if (Q191.Checked || Q192.Checked || Q193.Checked || Q194.Checked)
            {
                Q19 = true;
            }
            else
            {
                Q19 = false;
            }

            //Check pass
            if (Q11 == true && Q12 == true && Q13 == true && Q14 == true && Q15 == true && Q16 == true && Q17 == true && Q18 == true && Q19 == true)
            {
                return true;
            }

            return false;
        }

        bool Q2_Check()
        {
            //Check Radio_Checked
            bool Q21, Q22, Q23, Q24, Q25, Q26, Q27, Q28, Q29;
            if (Q211.Checked || Q212.Checked || Q213.Checked || Q214.Checked)
            {
                Q21 = true;
            }
            else
            {
                Q21 = false;
            }

            if (Q221.Checked || Q222.Checked || Q223.Checked || Q224.Checked)
            {
                Q22 = true;
            }
            else
            {
                Q22 = false;
            }

            if (Q231.Checked || Q232.Checked || Q233.Checked || Q234.Checked)
            {
                Q23 = true;
            }
            else
            {
                Q23 = false;
            }

            if (Q241.Checked || Q242.Checked || Q243.Checked || Q244.Checked)
            {
                Q24 = true;
            }
            else
            {
                Q24 = false;
            }

            if (Q251.Checked || Q252.Checked || Q253.Checked || Q254.Checked)
            {
                Q25 = true;
            }
            else
            {
                Q25 = false;
            }

            if (Q261.Checked || Q262.Checked || Q263.Checked || Q264.Checked)
            {
                Q26 = true;
            }
            else
            {
                Q26 = false;
            }

            if (Q271.Checked || Q272.Checked || Q273.Checked || Q274.Checked)
            {
                Q27 = true;
            }
            else
            {
                Q27 = false;
            }

            if (Q281.Checked || Q282.Checked || Q283.Checked || Q284.Checked)
            {
                Q28 = true;
            }
            else
            {
                Q28 = false;
            }

            if (Q291.Checked || Q292.Checked || Q293.Checked || Q294.Checked)
            {
                Q29 = true;
            }
            else
            {
                Q29 = false;
            }

            //Check pass
            if (Q21 == true && Q22 == true && Q23 == true && Q24 == true && Q25 == true && Q26 == true && Q27 == true && Q28 == true && Q29 == true)
            {
                return true;
            }

            return false;
        }

        bool Q3_Check()
        {
            //Check Radio_Checked
            bool Q31, Q32, Q33, Q34, Q35, Q36, Q37, Q38;
            if (Q311.Checked || Q312.Checked || Q313.Checked || Q314.Checked)
            {
                Q31 = true;
            }
            else
            {
                Q31 = false;
            }

            if (Q321.Checked || Q322.Checked || Q323.Checked || Q324.Checked)
            {
                Q32 = true;
            }
            else
            {
                Q32 = false;
            }

            if (Q331.Checked || Q332.Checked || Q333.Checked || Q334.Checked)
            {
                Q33 = true;
            }
            else
            {
                Q33 = false;
            }

            if (Q341.Checked || Q342.Checked || Q343.Checked || Q344.Checked)
            {
                Q34 = true;
            }
            else
            {
                Q34 = false;
            }

            if (Q351.Checked || Q352.Checked || Q353.Checked || Q354.Checked)
            {
                Q35 = true;
            }
            else
            {
                Q35 = false;
            }

            if (Q361.Checked || Q362.Checked || Q363.Checked || Q364.Checked)
            {
                Q36 = true;
            }
            else
            {
                Q36 = false;
            }

            if (Q371.Checked || Q372.Checked || Q373.Checked || Q374.Checked)
            {
                Q37 = true;
            }
            else
            {
                Q37 = false;
            }

            if (Q381.Checked || Q382.Checked || Q383.Checked || Q384.Checked)
            {
                Q38 = true;
            }
            else
            {
                Q38 = false;
            }

            //Check pass
            if (Q31 == true && Q32 == true && Q33 == true && Q34 == true && Q35 == true && Q36 == true && Q37 == true && Q38 == true)
            {
                return true;
            }

            return false;
        }

        bool Groupcheck()
        {
            bool pass1 = false, pass2 = false, pass3 = false;

            pass1 = Q1_Check();
            pass2 = Q2_Check();
            pass3 = Q3_Check();

            if (pass1 == true && pass2 == true && pass3 == true)
            {
                return true;
            }

            return false;
        }

        protected void ConfirmBtn_Click(object sender, EventArgs e)
        {
            bool pass = Groupcheck();

            if (pass == true)
            {
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue == "Yes")
                {
                    Session["report_id"] = Session["child_id"].ToString();
                    score_calculation();
                    if (Session["Report_Check_status"].ToString() == "parent")
                    {
                        Response.Redirect("Report_Parent.aspx");
                    }
                    else
                    {
                        Response.Redirect("Report_Teacher.aspx");
                    }

                }
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('กรุณาตรวจสอบคำตอบให้ครบทุกข้อ')</script>");
            }
        }
    }


}
