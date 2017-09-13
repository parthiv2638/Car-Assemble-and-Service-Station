using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_VehicleList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            var dataa = (from t in dc.Vehicles where t.Vid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
            if (dataa.Count == 1)
            {
                if (dataa[0].IsDisplay == true)
                {
                    dc.Vehicle_Delete(int.Parse(Request.QueryString["Id"]), false);
                }
                else
                {
                    dc.Vehicle_Delete(int.Parse(Request.QueryString["Id"]), true);
                }
                Response.Redirect("VehicleList.aspx");
            }
        }



        var data = (from t in dc.Vehicles select t).ToList();
        string str = "<table class ='table table-bordered table-hover'>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Vehicle Name</th><th>Vehicle Image</th><th>Want to Display?</th></tr>";
        foreach (var item in data)
        {
            string s = item.IsDisplay == true ? "Yes" : "No";
            str += "<tr><td><a href=VehicleEdit.aspx?Id=" + item.Vid + ">Edit</a></td><td><a href=VehicleList.aspx?Id=" + item.Vid + ">Delete</a></td><td>" + item.Vname + "</td><td>  <img src='../Images/" + item.Vimg + "' height ='100px' width ='100px' /></td><td>" + s + "</td></tr>";
        }
        str += "</table>";
        dis.InnerHtml = str;
    } 
}




