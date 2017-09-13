using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_WorkersList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            var dataa = (from t in dc.Users where t.Userid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
            if (dataa.Count == 1)
            {
                if (dataa[0].IsAuth == true)
                {
                    dc.User_Delete(int.Parse(Request.QueryString["Id"]), false);
                }
                else
                {
                    dc.User_Delete(int.Parse(Request.QueryString["Id"]), true);
                }
                Response.Redirect("WorkersList.aspx");
            }
        }


        var data = (from t in dc.Users where t.Did.Equals(3) select t).ToList();
        string str = "<table class ='table table-bordered table-hover'>";
        str += "<tr><th>Authenticate</th><th>User Name</th><th>Address</th><th>Contact No</th><th>Email</th><th>Image</th><th>Authenticate Or Not?</th></tr>";
        foreach (var item in data)
        {
            string s = item.IsAuth == true ? "Yes" : "No";
            str += "<tr><td><a href=WorkersEdit.aspx?Id=" + item.Userid + ">Edit</a></td><td>" + item.Username + "</td><td>" + item.Address + "</td><td>" + item.Contno + "</td><td>" + item.Email + "</td><td> <img src='../Images/" + item.Userimg + "' height ='100px' width ='100px' /></td><td>" + s + "</td></tr>";
        }
        str += "</table>";
        dis.InnerHtml = str;
    }
}