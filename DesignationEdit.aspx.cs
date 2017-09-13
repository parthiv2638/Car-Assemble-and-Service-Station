using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DesignationEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                var datad = (from t in dc.Designations
                             where t.Did.Equals(Request.QueryString["Id"])
                             select t).ToList();
                if (datad.Count == 1)
                {
                    txtDname.Text = datad[0].Dname;
                    if (datad[0].IsDisplay == true)
                    {
                        chkIsDisplay.Checked = true;
                    }
                }
            }
        }
    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            //update

            dc.Designation_Update(int.Parse(Request.QueryString["Id"]), txtDname.Text, chkIsDisplay.Checked);
            Response.Redirect("DesignationList.aspx");
        }
        else
        {
            //Insert       
            dc.Designation_Insert(txtDname.Text, chkIsDisplay.Checked);
            Response.Redirect("DesignationList.aspx");
        }
    }
}