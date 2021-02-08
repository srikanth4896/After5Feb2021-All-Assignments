using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrDnLiCountryStateCity
{
    public partial class CountryStateCity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (!Page.IsPostBack)
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select CountryName from Country", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {


                           
                                dt = new DataTable();
                                dt.Load(dr);

                                DropDownList1.DataSource = dt;

                            
                                DropDownList1.DataTextField = "CountryName";
                                

                                DropDownList1.DataBind();
                            


                        }


                    }
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = null;

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("StateSe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("CountryName", DropDownList1.SelectedValue);
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {

                        DropDownList2.Items.Clear();
                        DropDownList2.Items.Add("--Please choose State--");
                        dt = new DataTable();
                            dt.Load(dr);
                            DropDownList2.DataSource = dt;
                        
                        DropDownList2.DataTextField = "StateName";
                            DropDownList2.DataBind();

                    }

                }

            }




        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = null;

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("CitySe", cn))
                {
                    DropDownList3.Items.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("StateName", DropDownList2.SelectedValue);
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {

                        
                        dt = new DataTable();
                            dt.Load(dr);
                            DropDownList3.DataSource = dt;
                        
                        DropDownList3.DataTextField = "CityName";
                            DropDownList3.DataBind();


                    }

                }
            }

        }

    }
}
