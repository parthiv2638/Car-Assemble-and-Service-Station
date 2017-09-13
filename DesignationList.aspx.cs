using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DesignationList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            var dataa = (from t in dc.Designations where t.Did.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
            if (dataa.Count == 1)
            {
                if (dataa[0].IsDisplay == true)
                {
                    dc.Designation_Delete(int.Parse(Request.QueryString["Id"]), false);
                }
                else
                {
                    dc.Designation_Delete(int.Parse(Request.QueryString["Id"]), true);
                }
                Response.Redirect("DesignationList.aspx");
            }
        }



        var data = (from t in dc.Designations select t).ToList();
        string str = "<table class ='table table-bordered table-hover'>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Designation Name</th><th>Want To Display?</th></tr>";
        foreach (var item in data)
        {
            string s = item.IsDisplay == true ? "Yes" : "No";
            str += "<tr><td><a href=DesignationEdit.aspx?Id=" + item.Did + ">Edit</a></td><td><a href=DesignationList.aspx?Id=" + item.Did + ">Delete</a></td><td>" + item.Dname + "</td><td>" + s + "</td></tr>";
        }
        str += "</table>";
        dis.InnerHtml = str;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("DesignationEdit.aspx");
    }
}




