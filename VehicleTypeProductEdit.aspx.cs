using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_VehicleTypeProductEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var datap = (from t in dc.Products select t).ToList();
            ddlPro.DataSource = datap;
            ddlPro.DataTextField = "Pname";
            ddlPro.DataValueField = "Pid";
            ddlPro.DataBind();

            var datav = (from t in dc.Vehicles select t).ToList();
            ddlVecl.DataSource = datav;
            ddlVecl.DataTextField = "Vname";
            ddlVecl.DataValueField = "Vid";
            ddlVecl.DataBind();


            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                var datavtp = (from t in dc.VehicleType_Products
                               where t.VTypeProid.Equals(Request.QueryString["Id"])
                               select t).ToList();
                if (datavtp.Count == 1)
                {

                    ddlPro.SelectedValue = datavtp[0].Pid.ToString();
                    ddlVecl.SelectedValue = datavtp[0].Vid.ToString();
                    txtVTPPrc.Text = datavtp[0].VProprice.ToString();
                    if (datavtp[0].IsDisplay == true)
                    {
                        chkIsDisplay.Checked = true;
                    }
                }
            }
        }
    }
    //protected void btnSubmit_Click(object sender, EventArgs e)
    //{
        //if (!String.IsNullOrEmpty(Request.QueryString["Id"]))
        //{
        //    //update

        //    dc.VehicleTypeProduct_Update(int.Parse(Request.QueryString["Id"]), int.Parse(ddlPro.SelectedValue), int.Parse(ddlVecl.SelectedValue), int.Parse(txtVTPPrc.Text), chkIsDisplay.Checked);
        //    Response.Redirect("VehicleTypeProductList.aspx");
        //}
        //else
        //{
        //    //Insert
        //    dc.VehicleTypeProduct_Insert(int.Parse(ddlPro.SelectedValue), int.Parse(ddlVecl.SelectedValue), int.Parse(txtVTPPrc.Text), chkIsDisplay.Checked);
        //    Response.Redirect("VehicleTypeProductList.aspx");
        //}
    //}
    //protected void btnSubmit_Click1(object sender, EventArgs e)
    //{
    //    if (!String.IsNullOrEmpty(Request.QueryString["Id"]))
    //    {
    //        //update

    //        dc.VehicleTypeProduct_Update(int.Parse(Request.QueryString["Id"]), int.Parse(ddlPro.SelectedValue), int.Parse(ddlVecl.SelectedValue), int.Parse(txtVTPPrc.Text), chkIsDisplay.Checked);
    //        Response.Redirect("VehicleTypeProductList.aspx");
    //    }
    //    else
    //    {
    //        //Insert
    //        dc.VehicleTypeProduct_Insert(int.Parse(ddlPro.SelectedValue), int.Parse(ddlVecl.SelectedValue), int.Parse(txtVTPPrc.Text), chkIsDisplay.Checked);
    //        Response.Redirect("VehicleTypeProductList.aspx");
    //    }
    //}
    protected void btnSubmit_Click2(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            //update

            dc.VehicleTypeProduct_Update(int.Parse(Request.QueryString["Id"]), int.Parse(ddlPro.SelectedValue), int.Parse(ddlVecl.SelectedValue), int.Parse(txtVTPPrc.Text), chkIsDisplay.Checked);
            Response.Redirect("VehicleTypeProductList.aspx");
        }
        else
        {
            //Insert
            dc.VehicleTypeProduct_Insert(int.Parse(ddlPro.SelectedValue), int.Parse(ddlVecl.SelectedValue), int.Parse(txtVTPPrc.Text), chkIsDisplay.Checked);
            Response.Redirect("VehicleTypeProductList.aspx");
        }
    }
}