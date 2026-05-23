using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Assignment_1
{
    public partial class Products : System.Web.UI.Page
    {
        string conStr = ConfigurationManager.ConnectionStrings["ProductConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProducts();
                ddlProducts.Items.Insert(0, new ListItem("--Select Product--", ""));
            }
            
        }

        private void BindProducts()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("select P_Id, PName from Products", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                ddlProducts.DataSource = dr;
                ddlProducts.DataTextField = "PName";   
                ddlProducts.DataValueField = "P_Id";  
                ddlProducts.DataBind();

                conn.Close();
            }
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productId = int.Parse(ddlProducts.SelectedValue);

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("select P_ImgPath from Products where P_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", productId);
                conn.Open();
                string imgPath = cmd.ExecuteScalar()?.ToString();
                conn.Close();

                imgProduct.ImageUrl = imgPath;
                lblPrice.Text = "";
            }
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(ddlProducts.SelectedValue);

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("select price from Products where P_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", productId);
                conn.Open();
                string price = cmd.ExecuteScalar()?.ToString();
                conn.Close();

                lblPrice.Text = price;
            }
        }
    }
}