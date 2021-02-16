using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Globalization;

namespace Project
{

    public partial class Parent_graph : System.Web.UI.Page
    {
        string sql = @"Server=(LocalDB)\MSSQLLocalDB;Initial Catalog=Project_Senior;uid=sa;pwd=temp;";

        void chart1_load()
        {
            int score_1 = 16, score_2 = 13, score_3 = 15;

            LegendItem item1 = new LegendItem();
            item1.ImageStyle = LegendImageStyle.Rectangle;
            item1.BorderColor = Color.Red;
            item1.Color = Color.Red;
            item1.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item1.Cells.Add(LegendCellType.Text, "คะแนนมาตรฐานของผู้ปกครอง - 16 คะแนน", ContentAlignment.BottomRight);

            //Annotationline
            HorizontalLineAnnotation one = new HorizontalLineAnnotation();
            one.AxisX = Chart1.ChartAreas[0].AxisX;
            one.AxisY = Chart1.ChartAreas[0].AxisY;
            one.IsSizeAlwaysRelative = false;
            one.AnchorY = score_1;
            one.IsInfinitive = true;
            one.ClipToChartArea = Chart1.ChartAreas[0].Name;
            one.LineColor = Color.FromArgb(255,115,115); one.LineWidth = 2;
            one.LineDashStyle = ChartDashStyle.Dash;
            Chart1.Annotations.Add(one);
            Chart1.Legends[0].CustomItems.Add(item1);

            //Chart Details
            Chart1.ChartAreas[0].AxisY.Interval = 5;
            Chart1.ChartAreas[0].AxisY.Title = "คะแนน";
            Chart1.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;
            Chart1.ChartAreas[0].AxisY.TitleFont = new Font("Consolas", 12, FontStyle.Regular);
            Chart1.ChartAreas[0].AxisY2.LineColor = Color.Black;
            Chart1.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            Chart1.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            Chart1.ChartAreas[0].AxisY2.Interval = 5;
        }

        void chart2_load()
        {
            int score_2 = 13;

            LegendItem item2 = new LegendItem();
            item2.ImageStyle = LegendImageStyle.Rectangle;
            item2.BorderColor = Color.Red;
            item2.Color = Color.Red;
            item2.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item2.Cells.Add(LegendCellType.Text, "คะแนนมาตรฐานของผู้ปกครอง - 13 คะแนน", ContentAlignment.BottomRight);


            //Annotationline
            HorizontalLineAnnotation two = new HorizontalLineAnnotation();
            two.AxisX = Chart2.ChartAreas[0].AxisX;
            two.AxisY = Chart2.ChartAreas[0].AxisY;
            two.IsSizeAlwaysRelative = false;
            two.AnchorY = score_2;
            two.IsInfinitive = true;
            two.ClipToChartArea = Chart2.ChartAreas[0].Name;
            two.LineColor = Color.FromArgb(255, 115, 115); two.LineWidth = 2;
            two.LineDashStyle = ChartDashStyle.Dash;
            Chart2.Annotations.Add(two);

            //Chart Details
            Chart2.ChartAreas[0].AxisY.Interval = 5;
            Chart2.ChartAreas[0].AxisY.Title = "คะแนน";
            Chart2.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;
            Chart2.ChartAreas[0].AxisY.TitleFont = new Font("Consolas", 12, FontStyle.Regular);
            Chart2.ChartAreas[0].AxisY2.LineColor = Color.Black;
            Chart2.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            Chart2.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            Chart2.ChartAreas[0].AxisY2.Interval = 5;
            Chart2.Legends[0].CustomItems.Add(item2);
        }

        void chart3_load()
        {
            int score_3 = 15;

            LegendItem item3 = new LegendItem();
            item3.ImageStyle = LegendImageStyle.Rectangle;
            item3.BorderColor = Color.Red;
            item3.Color = Color.Red;
            item3.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item3.Cells.Add(LegendCellType.Text, "คะแนนมาตรฐานของผู้ปกครอง - 15 คะแนน", ContentAlignment.BottomRight);

            //Annotationline
            HorizontalLineAnnotation three = new HorizontalLineAnnotation();
            three.AxisX = Chart3.ChartAreas[0].AxisX;
            three.AxisY = Chart3.ChartAreas[0].AxisY;
            three.IsSizeAlwaysRelative = false;
            three.AnchorY = score_3;
            three.IsInfinitive = true;
            three.ClipToChartArea = Chart1.ChartAreas[0].Name;
            three.LineColor = Color.FromArgb(255, 115, 115); three.LineWidth = 2;
            three.LineDashStyle = ChartDashStyle.Dash;
            Chart3.Annotations.Add(three);

            //Chart Details
            Chart3.ChartAreas[0].AxisY.Interval = 5;
            Chart3.ChartAreas[0].AxisY.Title = "คะแนน";
            Chart3.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;
            Chart3.ChartAreas[0].AxisY.TitleFont = new Font("Consolas", 12, FontStyle.Regular);
            Chart3.ChartAreas[0].AxisY2.LineColor = Color.Black;
            Chart3.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            Chart3.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            Chart3.ChartAreas[0].AxisY2.Interval = 5;
            Chart3.Legends[0].CustomItems.Add(item3);
        }

        void chart4_load()
        {
            int score_1 = 23;

            LegendItem item1 = new LegendItem();
            item1.ImageStyle = LegendImageStyle.Rectangle;
            item1.BorderColor = Color.Purple;
            item1.Color = Color.Purple;
            item1.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item1.Cells.Add(LegendCellType.Text, "คะแนนมาตรฐานของครู - 23 คะแนน", ContentAlignment.BottomRight);

            //Annotationline
            HorizontalLineAnnotation one = new HorizontalLineAnnotation();
            one.AxisX = Chart1.ChartAreas[0].AxisX;
            one.AxisY = Chart1.ChartAreas[0].AxisY;
            one.IsSizeAlwaysRelative = false;
            one.AnchorY = score_1;
            one.IsInfinitive = true;
            one.ClipToChartArea = Chart1.ChartAreas[0].Name;
            one.LineColor = Color.FromArgb(253, 115, 255); one.LineWidth = 2;
            one.LineDashStyle = ChartDashStyle.Dash;
            Chart1.Annotations.Add(one);
            Chart1.Legends[0].CustomItems.Add(item1);

            //Chart Details
            Chart1.ChartAreas[0].AxisY.Interval = 5;
            Chart1.ChartAreas[0].AxisY.Title = "คะแนน";
            Chart1.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;
            Chart1.ChartAreas[0].AxisY.TitleFont = new Font("Consolas", 12, FontStyle.Regular);
            Chart1.ChartAreas[0].AxisY2.LineColor = Color.Black;
            Chart1.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            Chart1.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            Chart1.ChartAreas[0].AxisY2.Interval = 5;

        }

        void chart5_load()
        {
            int score_2 = 16;

            LegendItem item2 = new LegendItem();
            item2.ImageStyle = LegendImageStyle.Rectangle;
            item2.BorderColor = Color.Purple;
            item2.Color = Color.Purple;
            item2.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item2.Cells.Add(LegendCellType.Text, "คะแนนมาตรฐานของครู - 16 คะแนน", ContentAlignment.BottomRight);

            //Annotationline
            HorizontalLineAnnotation two = new HorizontalLineAnnotation();
            two.AxisX = Chart2.ChartAreas[0].AxisX;
            two.AxisY = Chart2.ChartAreas[0].AxisY;
            two.IsSizeAlwaysRelative = false;
            two.AnchorY = score_2;
            two.IsInfinitive = true;
            two.ClipToChartArea = Chart2.ChartAreas[0].Name;
            two.LineColor = Color.FromArgb(253, 115, 255); two.LineWidth = 2;
            two.LineDashStyle = ChartDashStyle.Dash;
            Chart2.Annotations.Add(two);

            //Chart Details
            Chart2.ChartAreas[0].AxisY.Interval = 5;
            Chart2.ChartAreas[0].AxisY.Title = "คะแนน";
            Chart2.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;
            Chart2.ChartAreas[0].AxisY.TitleFont = new Font("Consolas", 12, FontStyle.Regular);
            Chart2.ChartAreas[0].AxisY2.LineColor = Color.Black;
            Chart2.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            Chart2.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            Chart2.ChartAreas[0].AxisY2.Interval = 5;
            Chart2.Legends[0].CustomItems.Add(item2);
        }

        void chart6_load()
        {
            int score_3 = 11;

            LegendItem item3 = new LegendItem();
            item3.ImageStyle = LegendImageStyle.Rectangle;
            item3.BorderColor = Color.Purple;
            item3.Color = Color.Purple;
            item3.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item3.Cells.Add(LegendCellType.Text, "คะแนนมาตรฐานของครู - 11 คะแนน", ContentAlignment.BottomRight);

            //Annotationline
            HorizontalLineAnnotation three = new HorizontalLineAnnotation();
            three.AxisX = Chart3.ChartAreas[0].AxisX;
            three.AxisY = Chart3.ChartAreas[0].AxisY;
            three.IsSizeAlwaysRelative = false;
            three.AnchorY = score_3;
            three.IsInfinitive = true;
            three.ClipToChartArea = Chart1.ChartAreas[0].Name;
            three.LineColor = Color.FromArgb(253, 115, 255); three.LineWidth = 2;
            three.LineDashStyle = ChartDashStyle.Dash;
            Chart3.Annotations.Add(three);

            //Chart Details
            Chart3.ChartAreas[0].AxisY.Interval = 5;
            Chart3.ChartAreas[0].AxisY.Title = "คะแนน";
            Chart3.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;
            Chart3.ChartAreas[0].AxisY.TitleFont = new Font("Consolas", 12, FontStyle.Regular);
            Chart3.ChartAreas[0].AxisY2.LineColor = Color.Black;
            Chart3.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            Chart3.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            Chart3.ChartAreas[0].AxisY2.Interval = 5;
            Chart3.Legends[0].CustomItems.Add(item3);
        }

        void P1_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total1 = 0, score1;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart1.Series.Add("ผลประเมินของ" + codename);
                        Chart1.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerSize = 7;
                        Chart1.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart1.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Square;
                        Chart1.Series["ผลประเมินของ" + codename].Color = Color.Blue;
                        Chart1.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.Solid;
                        Chart1.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {
                                score1 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total1 = total1 + score1;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 9)
                                {
                                    Chart1.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total1);
                                    total1 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18 )
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void P2_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total1 = 0, score1;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart1.Series.Add("ผลประเมินของ" + codename);
                        Chart1.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerSize = 7;
                        Chart1.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart1.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Square;
                        Chart1.Series["ผลประเมินของ" + codename].Color = Color.Blue;
                        Chart1.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.DashDot;
                        Chart1.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {
                                score1 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total1 = total1 + score1;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 9)
                                {
                                    Chart1.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total1);
                                    total1 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void P3_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total1 = 0, score1;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart1.Series.Add("ผลประเมินของ" + codename);
                        Chart1.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerSize = 7;
                        Chart1.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart1.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Square;
                        Chart1.Series["ผลประเมินของ" + codename].Color = Color.Blue;
                        Chart1.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.Dot;
                        Chart1.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {
                                score1 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total1 = total1 + score1;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 9)
                                {
                                    Chart1.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total1);
                                    total1 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void T1_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total1 = 0, score1;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart1.Series.Add("ผลประเมินของ" + codename);
                        Chart1.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerSize = 12;
                        Chart1.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart1.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Star5;
                        Chart1.Series["ผลประเมินของ" + codename].Color = Color.Orange;
                        Chart1.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.Solid;
                        Chart1.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {
                                score1 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total1 = total1 + score1;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 9)
                                {
                                    Chart1.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total1);
                                    total1 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void T2_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total1 = 0, score1;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart1.Series.Add("ผลประเมินของ" + codename);
                        Chart1.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerSize = 12;
                        Chart1.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart1.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Star5;
                        Chart1.Series["ผลประเมินของ" + codename].Color = Color.Blue;
                        Chart1.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.DashDot;
                        Chart1.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {
                                score1 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total1 = total1 + score1;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 9)
                                {
                                    Chart1.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total1);
                                    total1 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void T3_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total1 = 0, score1;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart1.Series.Add("ผลประเมินของ" + codename);
                        Chart1.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerSize = 12;
                        Chart1.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart1.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart1.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Star5;
                        Chart1.Series["ผลประเมินของ" + codename].Color = Color.Orange;
                        Chart1.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.DashDotDot;
                        Chart1.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {
                                score1 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total1 = total1 + score1;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 9)
                                {
                                    Chart1.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total1);
                                    total1 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }


        void P7_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total2 = 0, score2;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart2.Series.Add("ผลประเมินของ" + codename);
                        Chart2.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerSize = 7;
                        Chart2.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart2.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Square;
                        Chart2.Series["ผลประเมินของ" + codename].Color = Color.Blue;
                        Chart2.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.Solid;
                        Chart2.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart2.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {
                                score2 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total2 = total2 + score2;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 18)
                                {
                                    Chart2.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total2);
                                    total2 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void P8_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total2 = 0, score2;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart2.Series.Add("ผลประเมินของ" + codename);
                        Chart2.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerSize = 7;
                        Chart2.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart2.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Square;
                        Chart2.Series["ผลประเมินของ" + codename].Color = Color.Blue;
                        Chart2.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.DashDot;
                        Chart2.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart2.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {
                                score2 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total2 = total2 + score2;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 18)
                                {
                                    Chart2.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total2);
                                    total2 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void P9_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total2 = 0, score2;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart2.Series.Add("ผลประเมินของ" + codename);
                        Chart2.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerSize = 7;
                        Chart2.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart2.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Square;
                        Chart2.Series["ผลประเมินของ" + codename].Color = Color.Blue;
                        Chart2.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.Dot;
                        Chart2.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart2.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {
                                score2 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total2 = total2 + score2;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 18)
                                {
                                    Chart2.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total2);
                                    total2 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void T7_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total2 = 0, score2;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart2.Series.Add("ผลประเมินของ" + codename);
                        Chart2.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerSize = 12;
                        Chart2.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart2.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Star5;
                        Chart2.Series["ผลประเมินของ" + codename].Color = Color.Orange;
                        Chart2.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.Solid;
                        Chart2.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart2.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {
                                score2 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total2 = total2 + score2;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 18)
                                {
                                    Chart2.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total2);
                                    total2 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void T8_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total2 = 0, score2;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart2.Series.Add("ผลประเมินของ" + codename);
                        Chart2.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerSize = 12;
                        Chart2.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart2.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Star5;
                        Chart2.Series["ผลประเมินของ" + codename].Color = Color.Orange;
                        Chart2.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.DashDot;
                        Chart2.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart2.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {
                                score2 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total2 = total2 + score2;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 18)
                                {
                                    Chart2.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total2);
                                    total2 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void T9_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total2 = 0, score2;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart2.Series.Add("ผลประเมินของ" + codename);
                        Chart2.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerSize = 12;
                        Chart2.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart2.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart2.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Star5;
                        Chart2.Series["ผลประเมินของ" + codename].Color = Color.Orange;
                        Chart2.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.DashDotDot;
                        Chart2.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart2.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {
                                score2 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total2 = total2 + score2;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 18)
                                {
                                    Chart2.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total2);
                                    total2 = 0;
                                }
                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {

                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void P13_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total3 = 0, score3;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart3.Series.Add("ผลประเมินของ" + codename);
                        Chart3.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerSize = 7;
                        Chart3.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart3.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Square;
                        Chart3.Series["ผลประเมินของ" + codename].Color = Color.Blue;
                        Chart3.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.Solid;
                        Chart3.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart3.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {
                                score3 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total3 = total3 + score3;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 26)
                                {
                                    Chart3.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total3);
                                    total3 = 0;
                                }
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void P14_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total3 = 0, score3;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart3.Series.Add("ผลประเมินของ" + codename);
                        Chart3.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerSize = 7;
                        Chart3.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart3.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Square;
                        Chart3.Series["ผลประเมินของ" + codename].Color = Color.Blue;
                        Chart3.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.DashDot;
                        Chart3.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart3.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {
                                score3 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total3 = total3 + score3;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 26)
                                {
                                    Chart3.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total3);
                                    total3 = 0;
                                }
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void P15_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total3 = 0, score3;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart3.Series.Add("ผลประเมินของ" + codename);
                        Chart3.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerSize = 7;
                        Chart3.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart3.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Square;
                        Chart3.Series["ผลประเมินของ" + codename].Color = Color.Blue;
                        Chart3.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.Dot;
                        Chart3.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart3.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {
                                score3 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total3 = total3 + score3;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 26)
                                {
                                    Chart3.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total3);
                                    total3 = 0;
                                }
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void T13_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total3 = 0, score3;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart3.Series.Add("ผลประเมินของ" + codename);
                        Chart3.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerSize = 12;
                        Chart3.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart3.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Star5;
                        Chart3.Series["ผลประเมินของ" + codename].Color = Color.Orange;
                        Chart3.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.Solid;
                        Chart3.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart3.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {
                                score3 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total3 = total3 + score3;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 26)
                                {
                                    Chart3.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total3);
                                    total3 = 0;
                                }
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void T14_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total3 = 0, score3;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart3.Series.Add("ผลประเมินของ" + codename);
                        Chart3.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerSize = 12;
                        Chart3.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart3.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Star5;
                        Chart3.Series["ผลประเมินของ" + codename].Color = Color.Orange;
                        Chart3.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.DashDot;
                        Chart3.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart3.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {
                                score3 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total3 = total3 + score3;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 26)
                                {
                                    Chart3.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total3);
                                    total3 = 0;
                                }
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void T15_series(string child_id, string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string query2 = "SELECT * FROM guardian_doq_naire WHERE child_child_id = '" + child_id + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DateTime dodate = DateTime.Now;
                    int total3 = 0, score3;
                    string codename = getcodeguardianname(user);
                    if (dr.HasRows)
                    {
                        Chart3.Series.Add("ผลประเมินของ" + codename);
                        Chart3.Series["ผลประเมินของ" + codename].ChartType = SeriesChartType.Line;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerSize = 12;
                        Chart3.Series["ผลประเมินของ" + codename].IsValueShownAsLabel = true;
                        Chart3.Series["ผลประเมินของ" + codename].BorderWidth = 3;
                        Chart3.Series["ผลประเมินของ" + codename].MarkerStyle = MarkerStyle.Star5;
                        Chart3.Series["ผลประเมินของ" + codename].Color = Color.Orange;
                        Chart3.Series["ผลประเมินของ" + codename].BorderDashStyle = ChartDashStyle.DashDotDot;
                        Chart3.Series["ผลประเมินของ" + codename].ToolTip = "วันที่ : #VALX";
                        Chart3.ChartAreas[0].AxisX.LabelStyle.Format = "MMMM yyyy";

                        int i = 0;
                        while (dr.Read())
                        {
                            if (i == 0 || i % 26 == 0)
                            {
                                dodate = dr.GetDateTime(dr.GetOrdinal("dodate"));
                            }

                            i++;
                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 0 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 9)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 10 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 18)
                            {

                            }

                            if (dr.GetInt32(dr.GetOrdinal("question_q_id")) >= 19 && dr.GetInt32(dr.GetOrdinal("question_q_id")) <= 26)
                            {
                                score3 = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("score")));
                                total3 = total3 + score3;
                                if (dr.GetInt32(dr.GetOrdinal("question_q_id")) == 26)
                                {
                                    Chart3.Series["ผลประเมินของ" + codename].Points.AddXY(dodate, total3);
                                    total3 = 0;
                                }
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        void graph()
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            int countP = 0 , countT = 0;
            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string group = "", user = "", child_id = "", user_status = "";
                    string[] words = line.Split();

                    for (int i = 0; i < words.Length; i++)
                    {
                        bool pass = false, check1 = false;
                        if (i == words.Length - 1)
                        {
                            break;
                        }

                        if (i % 5 == 0)
                        {
                            group = words[i].Trim();
                            user = words[i + 1].Trim();
                            child_id = words[i + 2].Trim();
                            user_status = words[i + 3].Trim();

                            if (group == Session["group"].ToString())
                                check1 = true;

                            if (check1 == true)
                            {
                                pass = true;
                            }

                            if (pass == true)
                            {
                                if (user_status == "ผู้ปกครอง" || user_status == "SP")
                                {
                                    if (countP == 0)
                                    {
                                        P1_series(child_id, user);
                                        countP++;
                                    }
                                    else if (countP == 1)
                                    {
                                        P2_series(child_id, user);
                                        countP++;
                                    }
                                    else if (countP == 2)
                                    {
                                        P3_series(child_id, user);
                                        countP++;
                                    }
                                }
                                else if (user_status == "ครู" || user_status == "ST")
                                {
                                    if (countT == 0)
                                    {
                                        T1_series(child_id, user);
                                        countT++;
                                    }
                                    else if (countT == 1)
                                    {
                                        T2_series(child_id, user);
                                        countT++;
                                    }
                                    else if (countT == 2)
                                    {
                                        T3_series(child_id, user);
                                        countT++;
                                    }
                                }

                                con.Close();


                            }
                        }
                        i = i + 4;
                    }
                }
            }
        }

        void graph2()
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            int countP = 0 , countT = 0;
            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string group = "", user = "", child_id = "", user_status = "";
                    string[] words = line.Split();

                    for (int i = 0; i < words.Length; i++)
                    {
                        bool pass = false, check1 = false;
                        if (i == words.Length - 1)
                        {
                            break;
                        }

                        if (i % 5 == 0)
                        {
                            group = words[i].Trim();
                            user = words[i + 1].Trim();
                            child_id = words[i + 2].Trim();
                            user_status = words[i + 3].Trim();

                            if (group == Session["group"].ToString())
                                check1 = true;

                            if (check1 == true)
                            {
                                pass = true;
                            }

                            if (pass == true)
                            {
                                if (user_status == "ผู้ปกครอง" || user_status == "SP")
                                {
                                    if (countP == 0)
                                    {
                                        P7_series(child_id, user);
                                        countP++;
                                    }
                                    else if (countP == 1)
                                    {
                                        P8_series(child_id, user);
                                        countP++;
                                    }
                                    else if (countP == 2)
                                    {
                                        P9_series(child_id, user);
                                        countP++;
                                    }
                                }
                                else if (user_status == "ครู" || user_status == "ST")
                                {
                                    if (countT == 0)
                                    {
                                        T7_series(child_id, user);
                                        countT++;
                                    }
                                    else if (countT == 1)
                                    {
                                        T8_series(child_id, user);
                                        countT++;
                                    }
                                    else if (countT == 2)
                                    {
                                        T9_series(child_id, user);
                                        countT++;
                                    }
                                }

                                con.Close();


                            }
                        }
                        i = i + 4;
                    }
                }
            }
        }

        void graph3()
        {
            SqlConnection con = new SqlConnection(sql);
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            int countP = 0 , countT = 0;
            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string group = "", user = "", child_id = "", user_status = "";
                    string[] words = line.Split();

                    for (int i = 0; i < words.Length; i++)
                    {
                        bool pass = false, check1 = false;
                        if (i == words.Length - 1)
                        {
                            break;
                        }

                        if (i % 5 == 0)
                        {
                            group = words[i].Trim();
                            user = words[i + 1].Trim();
                            child_id = words[i + 2].Trim();
                            user_status = words[i + 3].Trim();

                            if (group == Session["group"].ToString())
                                check1 = true;

                            if (check1 == true)
                            {
                                pass = true;
                            }

                            if (pass == true)
                            {
                                if (user_status == "ผู้ปกครอง" || user_status == "SP")
                                {
                                    if (countP == 0)
                                    {
                                        P13_series(child_id, user);
                                        countP++;
                                    }
                                    else if (countP == 1)
                                    {
                                        P14_series(child_id, user);
                                        countP++;
                                    }
                                    else if (countP == 2)
                                    {
                                        P15_series(child_id, user);
                                        countP++;
                                    }
                                }
                                else if (user_status == "ครู" || user_status == "ST")
                                {
                                    if (countP == 0)
                                    {
                                        T13_series(child_id, user);
                                        countP++;
                                    }
                                    else if (countP == 1)
                                    {
                                        T14_series(child_id, user);
                                        countP++;
                                    }
                                    else if (countP == 2)
                                    {
                                        T15_series(child_id, user);
                                        countP++;
                                    }
                                }

                                con.Close();


                            }
                        }
                        i = i + 4;
                    }
                }
            }
        }

        string getcodeguardianname(string user)
        {
            SqlConnection con = new SqlConnection(sql);
            string query = "SELECT * FROM guardian WHERE username = '" + user + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return dr["name"] + " " + dr["surname"];
                    }
                }
            }


            return "";
        }

        void ParentShow()
        {
            SqlConnection con = new SqlConnection(sql);

            if (ParentRadio.Checked == true)
            {
                foreach (var series in Chart1.Series)
                {
                    series.Points.Clear();
                }


                //get usernameofcode
                string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
                {
                    string line;
                    int Pcount = 0;
                    string childid1 = "", childid2 = "", childid3 = "";

                    con.Open();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string group = "", user = "", child_id = "", user_status = "", child_status = "";
                        string[] words = line.Split();

                        for (int i = 0; i < words.Length; i++)
                        {
                            bool pass = false, check1 = false;
                            if (i == words.Length - 1)
                            {
                                break;
                            }

                            if (i % 5 == 0)
                            {
                                group = words[i];
                                user = words[i + 1];
                                child_id = words[i + 2];
                                user_status = words[i + 3];

                                if (group == Session["group"].ToString())
                                    check1 = true;

                                if (check1 == true)
                                    pass = true;

                                if (pass == true)
                                {
                                    string codename = getcodeguardianname(user);

                                    if (user_status == "ผู้ปกครอง" || user_status == "SP")
                                    {
                                        if (Pcount == 0)
                                        {
                                            P1.Visible = true;
                                            P1.Enabled = true;
                                            childid1 = child_id;
                                            Pcount++;
                                            if (user == Session["user"].ToString())
                                            {
                                                P1.Text = codename + " - ตัวท่าน";
                                            }
                                            else if (child_status != "true")
                                            {
                                                P1.Text = codename;
                                            }
                                            else
                                            {
                                                P1.Text = codename;
                                            }
             
                                        }
                                        else if (Pcount == 1)
                                        {
                                            P2.Visible = true;
                                            P2.Enabled = true;
                                            childid2 = child_id;
                                            Pcount++;
                                            if (user == Session["user"].ToString())
                                            {
                                                P2.Text = codename + " - ตัวท่าน";
                                            }
                                            else if (child_status != "true")
                                            {
                                                P2.Text = codename;
                                            }
                                            else
                                            {
                                                P2.Text = codename + " - เพิกถอนไปแล้ว";
                                            }
                                        }
                                        else if (Pcount == 2)
                                        {
                                            P3.Visible = true;
                                            P3.Enabled = true;
                                            childid3 = child_id;
                                            P3.Text = codename;
                                            if (user == Session["user"].ToString())
                                            {
                                                P3.Text = codename + " - ตัวท่าน";
                                            }
                                            else if (child_status != "true")
                                            {
                                                P3.Text = codename;
                                            }
                                            else
                                            {
                                                P3.Text = codename + " - เพิกถอนไปแล้ว";
                                            }
                                        }

                                        if (P1.Checked == true && childid1 == child_id)
                                        {
                                            P1_series(childid1, user);

                                        }
                                        if (P2.Checked == true && childid2 == child_id)
                                        {
                                            P2_series(childid2, user);

                                        }
                                        if (P3.Checked == true && childid3 == child_id)
                                        {
                                            P3_series(childid3, user);

                                        }
                                    }
                                }
                            }
                        }
                    }
                    //End


                }
            }
        }

        void Teachershow()
        {
            SqlConnection con = new SqlConnection(sql);

            

            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            con.Open();
            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string line;
                int Tcount = 0;
                string childid4 = "", childid5 = "" , childid6 = "";
                
                while ((line = sr.ReadLine()) != null)
                {
                    string group = "", user = "", child_id = "", user_status = "", child_status = "";
                    string[] words = line.Split();

                    for (int i = 0; i < words.Length; i++)
                    {
                        bool pass = false, check1 = false;
                        if (i == words.Length - 1)
                        {
                            break;
                        }

                        if (i % 5 == 0)
                        {
                            group = words[i];
                            user = words[i + 1];
                            child_id = words[i + 2];
                            user_status = words[i + 3];
                            child_status = words[i + 4];

                            if (group == Session["group"].ToString())
                                check1 = true;

                            if (check1 == true)
                                pass = true;

                            if (pass == true)
                            {
                                string codename = getcodeguardianname(user);
                                if (user_status == "ครู" || user_status == "ST")
                                {
                                    if (Tcount == 0)
                                    {
                                        T1.Visible = true;
                                        T1.Enabled = true;
                                        childid4 = child_id;
                                        Tcount++;
                                        if (user == Session["user"].ToString())
                                        {
                                            T1.Text = codename + " - ตัวท่าน";
                                        }
                                        else if (child_status == "true")
                                        {
                                            T1.Text = codename;
                                        }
                                        else
                                        {
                                            T1.Text = codename + " - เพิกถอนไปแล้ว";
                                        }
                                    }
                                    else if (Tcount == 1)
                                    {
                                        T2.Visible = true;
                                        T2.Enabled = true;
                                        childid5 = child_id;
                                        Tcount++;
                                        if (user == Session["user"].ToString())
                                        {
                                            T2.Text = codename + " - ตัวท่าน";
                                        }
                                        else if (child_status == "true")
                                        {
                                            T2.Text = codename;
                                        }
                                        else
                                        {
                                            T2.Text = codename + " - เพิกถอนไปแล้ว";
                                        }
                                    }
                                    else if (Tcount == 2)
                                    {
                                        T3.Visible = true;
                                        T3.Enabled = true;
                                        childid6 = child_id;
                                        if (user == Session["user"].ToString())
                                        {
                                            T3.Text = codename + " - ตัวท่าน";
                                        }
                                        else if (child_status == "true")
                                        {
                                            T3.Text = codename;
                                        }
                                        else
                                        {
                                            T3.Text = codename + " - เพิกถอนไปแล้ว";
                                        }
                                    }



                                    if (T1.Checked == true && childid4 == child_id)
                                    {
                                        T1_series(childid4, user);

                                    }
                                    if (T2.Checked == true && childid5 == child_id)
                                    {
                                        T2_series(childid5, user);

                                    }
                                    if (T3.Checked == true && childid6 == child_id)
                                    {
                                        T3_series(childid6, user);

                                    }
                                }
                            }
                        }
                    }
                }
            }
            //end get user - name + surname
        }

        void ParentShow2()
        {
            SqlConnection con = new SqlConnection(sql);

            if (ParentRadio2.Checked == true)
            {
                

                foreach (var series in Chart2.Series)
                {
                    series.Points.Clear();
                }


                //get usernameofcode
                string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
                {
                    string line;
                    int Pcount = 0;
                    string childid1 = "", childid2 = "", childid3 = "";

                    con.Open();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string group = "", user = "", child_id = "", user_status = "" , child_status = "";
                        string[] words = line.Split();

                        for (int i = 0; i < words.Length; i++)
                        {
                            bool pass = false, check1 = false;
                            if (i == words.Length - 1)
                            {
                                break;
                            }

                            if (i % 5 == 0)
                            {
                                group = words[i];
                                user = words[i + 1];
                                child_id = words[i + 2];
                                user_status = words[i + 3];

                                if (group == Session["group"].ToString())
                                    check1 = true;

                                if (check1 == true)
                                    pass = true;

                                if (pass == true)
                                {
                                    string codename = getcodeguardianname(user);

                                    if (user_status == "ผู้ปกครอง" || user_status == "SP")
                                    {
                                        if (Pcount == 0)
                                        {
                                            P4.Visible = true;
                                            P4.Enabled = true;
                                            childid1 = child_id;
                                            Pcount++;
                                            if (user == Session["user"].ToString())
                                            {
                                                P4.Text = codename + " - ตัวท่าน";
                                            }
                                            else if (child_status != "true")
                                            {
                                                P4.Text = codename;
                                            }
                                            else
                                            {
                                                P4.Text = codename;
                                            }

                                        }
                                        else if (Pcount == 1)
                                        {
                                            P5.Visible = true;
                                            P5.Enabled = true;
                                            childid2 = child_id;
                                            Pcount++;
                                            if (user == Session["user"].ToString())
                                            {
                                                P5.Text = codename + " - ตัวท่าน";
                                            }
                                            else
                                            {
                                                P5.Text = codename;
                                            }
                                        }
                                        else if (Pcount == 2)
                                        {
                                            P6.Visible = true;
                                            P6.Enabled = true;
                                            childid3 = child_id;
                                            if (user == Session["user"].ToString())
                                            {
                                                P6.Text = codename + " - ตัวท่าน";
                                            }
                                            else
                                            {
                                                P6.Text = codename;
                                            }
                                        }

                                        if (P4.Checked == true && childid1 == child_id)
                                        {
                                            P7_series(childid1, user);

                                        }
                                        if (P5.Checked == true && childid2 == child_id)
                                        {
                                            P8_series(childid2, user);

                                        }
                                        if (P6.Checked == true && childid3 == child_id)
                                        {
                                            P9_series(childid3, user);

                                        }
                                    }
                                }
                            }
                        }
                    }
                    //End


                }
            }
        }

        void Teachershow2()
        {
            SqlConnection con = new SqlConnection(sql);

            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            con.Open();
            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string line;
                int Tcount = 0;
                string childid4 = "", childid5 = "" , childid6 = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string group = "", user = "", child_id = "", user_status = "" , child_status = "";
                    string[] words = line.Split();

                    for (int i = 0; i < words.Length; i++)
                    {
                        bool pass = false, check1 = false;
                        if (i == words.Length - 1)
                        {
                            break;
                        }

                        if (i % 5 == 0)
                        {
                            group = words[i];
                            user = words[i + 1];
                            child_id = words[i + 2];
                            user_status = words[i + 3];
                            child_status = words[i + 4];

                            if (group == Session["group"].ToString())
                                check1 = true;

                            if (check1 == true)
                                pass = true;

                            if (pass == true)
                            {
                                string codename = getcodeguardianname(user);

                                if (user_status == "ครู")
                                {
                                    if (Tcount == 0)
                                    {
                                        T4.Visible = true;
                                        T4.Enabled = true;
                                        childid4 = child_id;
                                        Tcount++;
                                        if (child_status != "true")
                                        {
                                            T4.Text = codename + " - เพิกถอน";
                                        }
                                        else
                                        {
                                            T4.Text = codename;
                                        }

                                    }
                                    else if (Tcount == 1)
                                    {
                                        T5.Visible = true;
                                        T5.Enabled = true;
                                        childid5 = child_id;
                                        Tcount++;
                                        if (child_status != "true")
                                        {
                                            T5.Text = codename + " - เพิกถอน";
                                        }
                                        else
                                        {
                                            T5.Text = codename;
                                        }

                                    }
                                    else if (Tcount == 2)
                                    {
                                        T6.Visible = true;
                                        T6.Enabled = true;
                                        childid6 = child_id;
                                        Tcount++;
                                        if (child_status != "true")
                                        {
                                            T6.Text = codename + " - เพิกถอน";
                                        }
                                        else
                                        {
                                            T6.Text = codename;
                                        }

                                    }
                                }

                                if (T4.Checked == true && childid4 == child_id)
                                {
                                    T7_series(childid4, user);

                                }
                                if (T5.Checked == true && childid5 == child_id)
                                {
                                    T8_series(childid5, user);

                                }
                                if (T6.Checked == true && childid5 == child_id)
                                {
                                    T9_series(childid6, user);

                                }
                            }
                        }
                    }
                }
            }
            //end get user - name + surname
        }

        void ParentShow3()
        {
            SqlConnection con = new SqlConnection(sql);

            if (ParentRadio3.Checked == true)
            {
                
                
                P7.Enabled = true;
                P8.Enabled = true;
                P9.Enabled = true;

                foreach (var series in Chart3.Series)
                {
                    series.Points.Clear();
                }


                //get usernameofcode
                string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
                {
                    string line;
                    int Pcount = 0;
                    string childid1 = "", childid2 = "", childid3 = "";

                    con.Open();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string group = "", user = "", child_id = "", user_status = "", child_status = "";
                        string[] words = line.Split();

                        for (int i = 0; i < words.Length; i++)
                        {
                            bool pass = false, check1 = false;
                            if (i == words.Length - 1)
                            {
                                break;
                            }

                            if (i % 5 == 0)
                            {
                                group = words[i];
                                user = words[i + 1];
                                child_id = words[i + 2];
                                user_status = words[i + 3];

                                if (group == Session["group"].ToString())
                                    check1 = true;

                                if (check1 == true)
                                    pass = true;

                                if (pass == true)
                                {
                                    string codename = getcodeguardianname(user);

                                    if (user_status == "ผู้ปกครอง" || user_status == "SP")
                                    {
                                        if (Pcount == 0)
                                        {
                                            P7.Visible = true;
                                            
                                            childid1 = child_id;
                                            Pcount++;
                                            if (user == Session["user"].ToString())
                                            {
                                                P7.Text = codename + " - ตัวท่าน";
                                            }
                                            else if (child_status != "true")
                                            {
                                                P7.Text = codename;
                                            }
                                            else
                                            {
                                                P7.Text = codename;
                                            }

                                        }
                                        else if (Pcount == 1)
                                        {
                                            P8.Visible = true;
                                            childid2 = child_id;
                                            Pcount++;
                                            if (user == Session["user"].ToString())
                                            {
                                                P8.Text = codename + " - ตัวท่าน";
                                            }
                                            else if (child_status != "true")
                                            {
                                                P8.Text = codename;
                                            }
                                            else
                                            {
                                                P8.Text = codename;
                                            }
                                        }
                                        else if (Pcount == 2)
                                        {
                                            P9.Visible = true;
                                            childid3 = child_id;
                                            if (user == Session["user"].ToString())
                                            {
                                                P9.Text = codename + " - ตัวท่าน";
                                            }
                                            else if (child_status != "true")
                                            {
                                                P9.Text = codename;
                                            }
                                            else
                                            {
                                                P9.Text = codename;
                                            }
                                        }

                                        if (P7.Checked == true && childid1 == child_id)
                                        {
                                            P13_series(childid1, user);
                                            P7.Visible = true;
                                            P7.Enabled = true;
                                        }
                                        if (P8.Checked == true && childid2 == child_id)
                                        {
                                            P14_series(childid2, user);
                                            P8.Visible = true;
                                            P8.Enabled = true;
                                        }
                                        if (P9.Checked == true && childid3 == child_id)
                                        {
                                            P15_series(childid3, user);
                                            P9.Visible = true;
                                            P9.Enabled = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //End


                }
            }
        }

        void Teachershow3()
        {
            SqlConnection con = new SqlConnection(sql);

            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            con.Open();
            using (StreamReader sr = new StreamReader(_filePath + "/Group_List.txt"))
            {
                string line;
                int Tcount = 0;
                string childid4 = "", childid5 = "" , childid6 = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string group = "", user = "", child_id = "", user_status = "", child_status = "";
                    string[] words = line.Split();

                    for (int i = 0; i < words.Length; i++)
                    {
                        bool pass = false, check1 = false;
                        if (i == words.Length - 1)
                        {
                            break;
                        }

                        if (i % 5 == 0)
                        {
                            group = words[i];
                            user = words[i + 1];
                            child_id = words[i + 2];
                            user_status = words[i + 3];
                            child_status = words[i + 4];

                            if (group == Session["group"].ToString())
                                check1 = true;

                            if (check1 == true)
                                pass = true;

                            if (pass == true)
                            {
                                string codename = getcodeguardianname(user);

                                if (user_status == "ครู" || user_status == "ST")
                                {
                                    if (Tcount == 0)
                                    {
                                        T7.Visible = true;
                                        T7.Enabled = true;
                                        childid4 = child_id;
                                        Tcount++;
                                        if (child_status != "true")
                                        {
                                            T7.Text = codename + " - เผิกถอน";
                                        }
                                        else
                                        {
                                            T7.Text = codename;
                                        }

                                    }
                                    else if (Tcount == 1)
                                    {
                                        T8.Visible = true;
                                        T8.Enabled = true;
                                        childid5 = child_id;
                                        Tcount++;
                                        if (child_status != "true")
                                        { 
                                            T8.Text = codename + " - เผิกถอน";
                                        }
                                        else
                                        {
                                            T8.Text = codename;
                                        }

                                    }
                                    else if (Tcount == 2)
                                    {
                                        T9.Visible = true;
                                        T9.Enabled = true;
                                        childid6 = child_id;
                                        if (child_status != "true")
                                        {
                                            T9.Text = codename + " - เผิกถอน";
                                        }
                                        else
                                        {
                                            T9.Text = codename;
                                        }

                                    }
                                }

                                if (T7.Checked == true && childid4 == child_id)
                                {
                                    T13_series(childid4, user);

                                }
                                if (T8.Checked == true && childid5 == child_id)
                                {
                                    T14_series(childid5, user);

                                }
                                if (T9.Checked == true && childid6 == child_id)
                                {
                                    T15_series(childid6, user);

                                }
                            }
                        }
                    }
                }
            }
            //end get user - name + surname
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = Session["child_name"] + " " + Session["child_surname"];
            
            if (all.Checked == true)
            {
                Title title = new Title();
                title.Font = new Font("Consolas", 16, FontStyle.Bold);
                title.Text = "ผลคะแนน";
                Chart1.Titles.Add(title);
                foreach (var series in Chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1_load();
                chart4_load();
                graph();
            }

            if (ParentRadio.Checked == true)
            {
                Title title = new Title();
                title.Font = new Font("Consolas", 16, FontStyle.Bold);
                title.Text = "ผลคะแนน";
                Chart1.Titles.Add(title);
                chart1_load();
                ParentShow();
            }
            else
            {
                P1.Visible = false;
                P2.Enabled = false;
                P3.Enabled = false;
                P1.Enabled = false;
                P2.Visible = false;
                P3.Visible = false;
            }


            if (TeacherRadio.Checked == true)
            {
                Title title = new Title();
                title.Font = new Font("Consolas", 16, FontStyle.Bold);
                title.Text = "ผลคะแนน";
                Chart1.Titles.Add(title);
                chart4_load();
                Teachershow();
            }
            else
            {
                T1.Visible = false;
                T1.Enabled = false;
                T2.Visible = false;
                T2.Enabled = false;
                T3.Visible = false;
                T3.Enabled = false;
            }

            if(all2.Checked == true)
            {
                Title title = new Title();
                title.Font = new Font("Consolas", 16, FontStyle.Bold);
                title.Text = "ผลคะแนน";
                Chart2.Titles.Add(title);
                foreach (var series in Chart2.Series)
                {
                    series.Points.Clear();
                }
                chart2_load();
                chart5_load();
                graph2();
            }

            if(ParentRadio2.Checked == true)
            {
                Title title = new Title();
                title.Font = new Font("Consolas", 16, FontStyle.Bold);
                title.Text = "ผลคะแนน";
                Chart2.Titles.Add(title);
                chart2_load();
                ParentShow2();
            }
            else
            {
                P4.Visible = false;
                P5.Visible = false;
                P6.Visible = false;
                P4.Enabled = false;
                P5.Enabled = false;
                P6.Enabled = false;
            }

            if(TeacherRadio2.Checked == true)
            {
                Title title = new Title();
                title.Font = new Font("Consolas", 16, FontStyle.Bold);
                title.Text = "ผลคะแนน";
                Chart2.Titles.Add(title);
                Teachershow2();
                chart5_load();
            }
            else
            {
                T4.Visible = false;
                T4.Enabled = false;
                T5.Visible = false;
                T5.Enabled = false;
                T6.Visible = false;
                T6.Enabled = false;
            }

            if (all3.Checked == true)
            {
                Title title = new Title();
                title.Font = new Font("Consolas", 16, FontStyle.Bold);
                title.Text = "ผลคะแนน";
                Chart3.Titles.Add(title);
                foreach (var series in Chart3.Series)
                {
                    series.Points.Clear();
                }
                chart3_load();
                chart6_load();
                graph3();
            }

            if (ParentRadio3.Checked == true)
            {
                Title title = new Title();
                title.Font = new Font("Consolas", 16, FontStyle.Bold);
                title.Text = "ผลคะแนน";
                Chart3.Titles.Add(title);
                chart3_load();
                ParentShow3();
            }
            else
            {
                P7.Visible = false;
                P8.Visible = false;
                P9.Visible = false;
                P7.Enabled = false;
                P8.Enabled = false;
                P9.Enabled = false;
            }

            if (TeacherRadio3.Checked == true)
            {
                Title title = new Title();
                title.Font = new Font("Consolas", 16, FontStyle.Bold);
                title.Text = "ผลคะแนน";
                Chart3.Titles.Add(title);
                Teachershow3();
                chart6_load();
            }
            else
            {
                T7.Visible = false;
                T7.Enabled = false;
                T8.Visible = false;
                T8.Enabled = false;
                T9.Visible = false;
                T9.Enabled = false;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Child_List.aspx");
        }
    }
}