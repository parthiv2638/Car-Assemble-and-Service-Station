using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_OperatorEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {
                    var datav = (from t in dc.Users
                                 where t.Userid.Equals(Request.QueryString["Id"])
                                 select t).ToList();
                    if (datav.Count == 1)
                    {
                        txtUname.Text = datav[0].Username;
                        if (datav[0].IsAuth == true)
                        {
                            chkIsDisplay.Checked = true;
                        }
                    }
                }
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        dc.Authenticate_Update(int.Parse(Request.QueryString["Id"]),chkIsDisplay.Checked);
        Response.Redirect("~/Admin/Adminhome.aspx");
    }
}