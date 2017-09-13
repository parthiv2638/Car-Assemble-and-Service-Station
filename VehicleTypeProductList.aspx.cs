using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_VehicleTypeProductList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            var dataa = (from t in dc.VehicleType_Products where t.VTypeProid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
            if (dataa.Count == 1)
            {
                if (dataa[0].IsDisplay == true)
                {
                    dc.VehicleTypeProduct_Delete(int.Parse(Request.QueryString["Id"]), false);
                }
                else
                {
                    dc.VehicleTypeProduct_Delete(int.Parse(Request.QueryString["Id"]), true);
                }
                Response.Redirect("VehicleTypeProductList.aspx");
            }
        }



        var data = (from t in dc.VehicleType_Products
                    join tp in dc.Products on t.Pid equals tp.Pid
                    join tv in dc.Vehicles on t.Vid equals tv.Vid
                    select new
                    {
                        t.VTypeProid,
                        tp.Pname,
                        tv.Vname,
                        t.VProprice,
                        t.IsDisplay
                    }).ToList();
        string str = "<table class ='table table-bordered table-hover'>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Product Name</th><th>Vehicle Name</th><th>Vehicle Product Price</th><th>Want To Display?</th></tr>";
        foreach (var item in data)
        {
            string s = item.IsDisplay == true ? "Yes" : "No";
            str += "<tr><td><a href=VehicleTypeProductEdit.aspx?Id=" + item.VTypeProid + ">Edit</a></td><td><a href=VehicleTypeProductList.aspx?Id=" + item.VTypeProid + ">Delete</a></td><td>" + item.Pname + "</td><td>" + item.Vname + "</td><td>" + item.VProprice + "</td><td>" + s + "</td></tr>";
        }
        str += "</table>";
        dis.InnerHtml = str;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("VehicleTypeProductEdit.aspx");
    }
}





