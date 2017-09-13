using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_Customerhome : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            //var datav = (from t in dc.Vehicles select t).ToList();
            //ddlVecl.DataSource = datav;
            //ddlVecl.DataTextField = "Vname";
            //ddlVecl.DataValueField = "Vid";
            //ddlVecl.DataBind();



            //var datano = (from t in dc.CarPosts select t).ToList();
            //ddlModelno.DataSource = datano;
            //ddlModelno.DataTextField = "ModelNo";
            //ddlModelno.DataValueField = "Carid";
            //ddlModelno.DataBind();




            //var dataf = (from t in dc.CarPosts select t).ToList();
            //chkFuelType.DataSource = dataf;
            //chkFuelType.DataTextField = "FuelType";
            //chkFuelType.DataValueField = "Carid";
            //chkFuelType.DataBind();



            //var dataprc = (from t in dc.CarPosts select t).ToList();
            //chkCarColor.DataSource = dataf;
            //chkCarColor.DataTextField = "CarColor";
            //chkCarColor.DataValueField = "Carid";
            //chkCarColor.DataBind();
        }
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            //var dataa = (from t in dc.VehicleType_Products where t.VTypeProid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
            //if (dataa.Count == 1)
            //{
            //    if (dataa[0].IsDisplay == true)
            //    {
            //        dc.VehicleTypeProduct_Delete(int.Parse(Request.QueryString["Id"]), false);
            //    }
            //    else
            //    {
            //        dc.VehicleTypeProduct_Delete(int.Parse(Request.QueryString["Id"]), true);
            //    }
            //    Response.Redirect("VehicleTypeProductList.aspx");
            //}
        }
      


        var data = (from t in dc.VehicleNumbers
                    join tv in dc.Vehicles on t.Vid equals tv.Vid
                    join tvn in dc.VehicleNumbers on t.Vnumberid equals tvn.Vnumberid
                    where t.Userid.Equals(Session["Userid"])
                    select new
                    {
                        t.Vnumberid,
                        tv.Vid,
                        tv.Vname,
                        tv.Vimg
                    }).ToList();
        string str = "<div class='offer_list clearfix' style ='height :200px' width='100px;'>";

        for (int i = 0; i < data.Count;i++ )
        {
        str +="<div class='offer_item clearfix'>";
        str += "<div class='offer_image'>";
        str += "<a><img src='../Images/" + data[i].Vimg + "' height ='162px' width ='230px'></a>";
        str += "</div>";
        str += "<div class='offer_aside'>";
        str += "<h2><a href=CustProductList.aspx?Id=" + data[i].Vid + ">" + data[i].Vname + "</a></h2>";
        str += "<div class='offer_descr'>";
        str += "<font color='orange'><h2>See Car Products</h2></font>";
        str += "</div>";
        str += "</div>";
        str += "</div>";
        }
        str += "</div>";
        dis.InnerHtml = str;
    }
    


    //protected void btnAdd_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("VehicleTypeProductEdit.aspx");
    //}
    //protected void ddlVehl_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}
    //protected void chkFuelType_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}
    //protected void chkCarColor_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}
}