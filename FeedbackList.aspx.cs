using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FeedbackList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            var dataa = (from t in dc.Feedbacks where t.Fid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
            if (dataa.Count == 1)
            {
                if (dataa[0].IsDisplay == true)
                {
                    dc.Feedback_Delete(int.Parse(Request.QueryString["Id"]), false);
                }
                else
                {
                    dc.Feedback_Delete(int.Parse(Request.QueryString["Id"]), true);
                }
                Response.Redirect("FeedbackList.aspx");
            }
        }

        var data = (from t in dc.Feedbacks
                    join tu in dc.Users on t.Userid equals tu.Userid
                    select new
                    {
                        t.Fid,
                        t.Feedback1,
                        t.DOF,
                        t.IsDisplay,
                        tu.Fname,
                        tu.Userimg
                    }).ToList();
        string str = "<table class ='table table-bordered table-hover'>";
        str += "<tr><th>Feedback</th><th>Date of Feedback</th><th>User Name</th><th>User Name</th><th>Want to display?</th></tr>";
        foreach (var item in data)
        {
            string s = item.IsDisplay == true ? "Yes" : "No";
            str += "<tr><td>" + item.Feedback1 + "</td><td>" + item.DOF + "</td><td>" + item.Fname + "</td><td>  <img src='../Images/" + item.Userimg + "' height ='100px' width ='100px' /></td><td>" + s + "</td></tr>";
        }
        str += "</table>";
        dis.InnerHtml = str;
        //<a href=FeedbackEdit.aspx?Id=" + item.Fid + ">Edit</a></td><td><a href=FeedbackEdit.aspx?Id=" + item.Fid + ">Delete</a></td>
    }
}
