using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_PackageTypeEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                var datav = (from t in dc.PackageTypes
                             where t.Packtid.Equals(Request.QueryString["Id"])
                             select t).ToList();
                if (datav.Count == 1)
                {
                    txtPackname.Text = datav[0].Packname;
                    txtPackamt.Text = datav[0].Packamt.ToString();
                    //Image1.ImageUrl = "~/Images/" + datav[0].Packimg;
                    txtPackDes1.Text = datav[0].Packdes1;
                    txtPackDes2.Text = datav[0].Packdes2;
                    txtPackDes3.Text = datav[0].Packdes3;
                    txtPackDes4.Text = datav[0].Packdes4;
                    txtPackBest.Text = datav[0].Packbest;
                    // HiddenField1.Value = datav[0].Packimg;
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
            //if (FuImage.HasFile == true)
            //{
            //    FuImage.SaveAs(Server.MapPath("Images") + FuImage.FileName);
            dc.PackageType_Update(int.Parse(Request.QueryString["Id"]), txtPackname.Text, int.Parse(txtPackamt.Text), txtPackDes1.Text, txtPackDes2.Text, txtPackDes3.Text, txtPackDes4.Text, txtPackBest.Text, chkIsDisplay.Checked);
            Response.Redirect("PackageTypeList.aspx");
        }
        //else
        //{
        //    dc.PackageType_Update(int.Parse(Request.QueryString["Id"]), txtPackname.Text, int.Parse(txtPackamt.Text), HiddenField1.Value, txtPackDes1.Text, txtPackDes2.Text, txtPackDes3.Text, txtPackDes4.Text, txtPackBest.Text, chkIsDisplay.Checked);
        //    Response.Redirect("PackageTypeList.aspx");
        //}
        //}
        else
        {
            //Insert
            //if (FuImage.HasFile == true)
            //{
            //    FuImage.SaveAs(Server.MapPath("../Images/") + FuImage.FileName);
            dc.PackageType_Insert(txtPackname.Text, int.Parse(txtPackamt.Text), txtPackDes1.Text, txtPackDes2.Text, txtPackDes3.Text, txtPackDes4.Text, txtPackBest.Text, chkIsDisplay.Checked);
            Response.Redirect("PackageTypeList.aspx");
        }
    }
}