using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_PackageTypeList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            var dataa = (from t in dc.PackageTypes where t.Packtid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
            if (dataa.Count == 1)
            {
                if (dataa[0].IsDisplay == true)
                {
                    dc.PackageType_Delete(int.Parse(Request.QueryString["Id"]), false);
                }
                else
                {
                    dc.PackageType_Delete(int.Parse(Request.QueryString["Id"]), true);
                }
                Response.Redirect("PackageTypeList.aspx");
            }
        }



        var data = (from t in dc.PackageTypes select t).ToList();
        string str = "<table class ='table table-bordered table-hover'>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Package Name</th><th>Package Amount</th><th>Pack Des 1</th><th>Pack Des 2</th><th>Pack Des 3</th><th>Pack Des 4</th><th>Pack Best</th><th>Want to Display?</th></tr>";
        foreach (var item in data)
        {
            string s = item.IsDisplay == true ? "Yes" : "No";
            str += "<tr><td><a href=PackageTypeEdit.aspx?Id=" + item.Packtid + ">Edit</a></td><td><a href=PackageTypeList.aspx?Id=" + item.Packtid + ">Delete</a></td><td>" + item.Packname + "</td><td>" + item.Packamt + "</td><td>" +  item.Packdes1 + "</td><td>" +  item.Packdes2 + "</td><td>" + item.Packdes3 + "</td><td>" + item.Packdes4 + "</td><td>" + item.Packbest + "</td><td>" + s + "</td></tr>";
        }
        str += "</table>";
        dis.InnerHtml = str;
    }
}
