using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ProductList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            var dataa = (from t in dc.Products where t.Pid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
            if (dataa.Count == 1)
            {
                if (dataa[0].IsDisplay == true)
                {
                    dc.Product_Delete(int.Parse(Request.QueryString["Id"]), false);
                }
                else
                {
                    dc.Product_Delete(int.Parse(Request.QueryString["Id"]), true);
                }
                Response.Redirect("ProductList.aspx");
            }
        }



        var data = (from t in dc.Products select t).ToList();
        string str = "<table class ='table table-bordered table-hover'>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Product Name</th><th>Product Image</th><th>Want To Display?</th></tr>";
        foreach (var item in data)
        {
            string s = item.IsDisplay == true ? "Yes" : "No";
            str += "<tr><td><a href=ProductEdit.aspx?Id=" + item.Pid + ">Edit</a></td><td><a href=ProductList.aspx?Id=" + item.Pid + ">Delete</a></td><td>" + item.Pname + "</td><td>  <img src='../Images/" + item.Pimg + "' height ='100px' width ='100px' /></td><td>" + s + "</td></tr>";
        }
        str += "</table>";
        dis.InnerHtml = str;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductEdit.aspx");
    }
}




