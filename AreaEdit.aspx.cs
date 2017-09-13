using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AreaEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                var dataa = (from t in dc.Areas
                             where t.AreaId.Equals(Request.QueryString["Id"])
                             select t).ToList();
                if (dataa.Count == 1)
                {
                    txtAname.Text = dataa[0].AreaName;
                    if (dataa[0].IsDisplay == true)
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

            dc.Area_Update(int.Parse(Request.QueryString["Id"]), txtAname.Text, chkIsDisplay.Checked);
            Response.Redirect("AreaList.aspx");
        }
        else
        {
            //Insert       
            dc.Area_Insert(txtAname.Text, chkIsDisplay.Checked);
            Response.Redirect("AreaList.aspx");
        }
    }
}