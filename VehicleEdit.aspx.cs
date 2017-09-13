using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_VehicleEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                 var datav = (from t in dc.Vehicles
                             where t.Vid.Equals(Request.QueryString["Id"])
                             select t).ToList();
                if (datav.Count == 1)
                {
                    txtVname.Text = datav[0].Vname;
                    Image1.ImageUrl = "~/Images/" + datav[0].Vimg;
                    HiddenField1.Value = datav[0].Vimg;
                    if (datav[0].IsDisplay == true)
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
            if (FuImage.HasFile == true)
            {
                FuImage.SaveAs(Server.MapPath("Images") + FuImage.FileName);
                dc.Vehicle_Update(int.Parse(Request.QueryString["Id"]), txtVname.Text, FuImage.FileName, chkIsDisplay.Checked);
                Response.Redirect("VehicleList.aspx");
            }
            else
            {
                dc.Vehicle_Update(int.Parse(Request.QueryString["Id"]), txtVname.Text, HiddenField1.Value, chkIsDisplay.Checked);
                Response.Redirect("VehicleList.aspx");
            }
        }
        else
        {
            //Insert
            if (FuImage.HasFile == true)
            {
                FuImage.SaveAs(Server.MapPath("../Images/") + FuImage.FileName);
                dc.Vehicle_Insert(txtVname.Text, FuImage.FileName, chkIsDisplay.Checked);
                Response.Redirect("VehicleList.aspx");
            }
        }
    }
}




