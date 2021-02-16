using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;

namespace Project
{
    public partial class Report_Parent : System.Web.UI.Page
    {
        private string sql = @"Server=(LocalDB)\MSSQLLocalDB;Initial Catalog=Project_Senior;uid=sa;pwd=temp;Integrated Security=True";

        void score_result()
        {
            SqlConnection con = new SqlConnection(sql);
            int score1 = 0, score2 = 0, score3 = 0;
            string query = "SELECT TOP 26 * FROM guardian_doq_naire WHERE child_child_id = '" + Session["report_id"] + "' ORDER BY Do_ID DESC";
            DateTime date = DateTime.Now;
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {


                        //Q1
                        if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 1 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                        {
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 1)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score1 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score1 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score1 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score1 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 2)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score1 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score1 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score1 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score1 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 3)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score1 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score1 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score1 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score1 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 4)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score1 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score1 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score1 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score1 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 5)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score1 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score1 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score1 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score1 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 6)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score1 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score1 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score1 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score1 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 7)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score1 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score1 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score1 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score1 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 8)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score1 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score1 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score1 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score1 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 9)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score1 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score1 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score1 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score1 += 3;
                                }
                            }
                        }

                        //Q2
                        if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                        {
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 10)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score2 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score2 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score2 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score2 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 11)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score2 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score2 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score2 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score2 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 12)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score2 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score2 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score2 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score2 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 13)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score2 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score2 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score2 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score2 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 14)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score2 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score2 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score2 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score2 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 15)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score2 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score2 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score2 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score2 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 16)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score2 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score2 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score2 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score2 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 17)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score2 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score2 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score2 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score2 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 18)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score2 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score2 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score2 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score2 += 3;
                                }
                            }
                            //End Q2



                        }

                        //Q3
                        if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                        {
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 19)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score3 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score3 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score3 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score3 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 20)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score3 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score3 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score3 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score3 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 21)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score3 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score3 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score3 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score3 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 22)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score3 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score3 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score3 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score3 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 23)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score3 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score3 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score3 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score3 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 24)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score3 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score3 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score3 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score3 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 25)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score3 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score3 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score3 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score3 += 3;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 26)
                            {
                                if (dr.GetDecimal(dr.GetOrdinal("score")) == 0)
                                {
                                    score3 += 0;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 1)
                                {
                                    score3 += 1;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 2)
                                {
                                    score3 += 2;
                                }
                                else if (dr.GetDecimal(dr.GetOrdinal("score")) == 3)
                                {
                                    score3 += 3;
                                }
                            }
                            //End IF Q19 -> Q26
                        }
                    }
                }
            }

            string name = "";
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM child WHERE child_id = '" + Session["report_id"] + "'", con);
            using(SqlDataReader dr = cmd2.ExecuteReader())
            {
                if(dr.HasRows)
                {
                    if (dr.Read())
                    {
                        name = dr["name"] + " " + dr["surname"];
                    }
                }
            }

            Label6.Text = "วันที่ " + date.ToString("dd MMMM yyyy", new CultureInfo("th-TH"));

            //label Message
            Label4.Text = name;
            string risk1 = "" , risk2 = "";
            int risk = 0;
            if(score1 >= 16)
            {
                Panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#F04646");
                Panel1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#F04646");
                risk++;
                if(risk1 == "")
                {
                    risk1 = "ขาดสมาธิ";
                }
                else
                {
                    risk2 = "ขาดสมาธิ";
                }
            }
            else
            {
                Panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#76FF76");
                Panel1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#76FF76");
            }
            if(score2 >= 13)
            {
                Panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#F04646");
                Panel2.BorderColor = System.Drawing.ColorTranslator.FromHtml("#F04646");
                risk++;
                if (risk1 == "")
                {
                    risk1 = "ซนอยู่ไม่นิ่ง / หุนหันพลันแล่น";
                }
                else
                {
                    risk2 = "ซนอยู่ไม่นิ่ง / หุนหันพลันแล่น";
                }
            }
            else
            {
                Panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#76FF76");
                Panel2.BorderColor = System.Drawing.ColorTranslator.FromHtml("#76FF76");
            }
            if (score3 >= 15)
            {
                Panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#F04646");
                Panel3.BorderColor = System.Drawing.ColorTranslator.FromHtml("#F04646"); 
                risk++;
                if (risk1 == "")
                {
                    risk1 = "ดื้อ/ต่อต้าน";
                }
                else if (risk2 != "")
                {
                    risk2 = "ดื้อ/ต่อต้าน";
                }
            }
            else
            {
                Panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#76FF76");
                Panel3.BorderColor = System.Drawing.ColorTranslator.FromHtml("#76FF76");
            }

            Label1.Text = score1.ToString();
            Label2.Text = score2.ToString();
            Label3.Text = score3.ToString();

            if(risk == 1)
            {
                Label5.Text = "มีความเสี่ยงที่จะเกิดอาการ " + risk1 + " ทั้งนี้ต้องประเมินอย่างสม่ำเสมอติดต่อกัน 6 เดือน เพื่อสังเกตุกราฟผลคะแนน";
            }
            else if (risk == 2)
            {
                Label5.Text = "มีความเสี่ยงที่จะเกิดอาการ " + risk1 + " และอาการ " + risk2 + " ทั้งนี้ต้องประเมินอย่างสม่ำเสมอติดต่อกัน 6 เดือน เพื่อสังเกตุกราฟผลคะแนน";
            }
            else if (risk == 3)
            {
                Label5.Text = "มีความเสี่ยงที่จะเกิดอาการทั้ง 3 อาการทั้งนี้ต้องประเมินผลอย่างสม่ำเสมอติดต่อกัน 6 เดือน เพื่อสังเกตุกราฟผลคะแนน";
            }
            else
            {
                Label5.Text = "มีคะแนนในระดับต่ำกว่ามาตราฐานยังไม่มีความเสี่ยงที่จะเกิดอาการใด ๆ ทั้งนี้ต้องประเมินอย่างสม่ำเสมอติดต่อกัน 6 เดือน เพื่อสังเกตุกราฟผลคะแนน";
            }

            con.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            score_result();
            Panel1.BorderWidth = 4;
            Panel2.BorderWidth = 4;
            Panel3.BorderWidth = 4;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["child_id"] = Session["report_id"];
            Response.Redirect("Parent_graph.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Child_List.aspx");
        }
    }
}