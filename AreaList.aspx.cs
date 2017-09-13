using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AreaList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            var dataa = (from t in dc.Areas where t.AreaId.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
            if (dataa.Count == 1)
            {
                if (dataa[0].IsDisplay == true)
                {
                    dc.Area_Delete(int.Parse(Request.QueryString["Id"]), false);
                }
                else
                {
                    dc.Area_Delete(int.Parse(Request.QueryString["Id"]), true);
                }
                Response.Redirect("AreaList.aspx");
            }
        }



        var data = (from t in dc.Areas select t).ToList();
        string str = "<table class ='table table-bordered table-hover'>";
        str += "<tr><th>Edit</th><th>Delete</th><th>AreaName</th><th>Want To Display?</th></tr>";
        foreach (var item in data)
        {
            string s = item.IsDisplay == true ? "Yes" : "No";
            str += "<tr><td><a href=AreaEdit.aspx?Id=" + item.AreaId + ">Edit</a></td><td><a href=AreaList.aspx?Id=" + item.AreaId + ">Delete</a></td><td>" + item.AreaName + "</td><td>" + s + "</td></tr>";
        }
        str += "</table>";
        dis.InnerHtml = str;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AreaEdit.aspx");
    }
}