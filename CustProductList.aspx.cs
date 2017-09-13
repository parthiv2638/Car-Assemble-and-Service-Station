using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_CustProductList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
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



        var data = (from t in dc.VehicleType_Products
                    join tp in dc.Products on t.Pid equals tp.Pid
                    where t.Vid.Equals(int.Parse(Request.QueryString["Id"]))
                    select new
                    {
                        t.VTypeProid,
                        tp.Pid,
                        tp.Pname,
                        tp.Pimg,
                        t.VProprice
                    }).ToList();
        string str = "<div class='container clearfix'>";
        str += "<div class='content'>";
        str += "<div class='brand_list2'>";
        str += "<ul>";
        for (int i = 0; i < data.Count; i++)
        {
        str +="<li>";
        str += "<a class='brand_logo' href='BookAService.aspx' hidefocus='true' style='outline: medium none;'><img src='../Images/" + data[i].Pimg + "' height ='162px' width ='230px'></a>";
        str += "<a href='BookAService.aspx' hidefocus='true' style='outline: medium none;'>" + data[i].Pname + "</a>";
        str += "</li>";
        }
            //str += "<td> <img src='../Images/" + data[i].Pimg + "' height ='100px' width ='100px' /><br/><a href=CustProductLis.aspx?Id=" + data[i].Pid + ">" + data[i].Pname + "</a><br/>" + data[i].VProprice + "</td>";
        str += "</ul>";
        str += "</div>";
        str += "</div>";
        str += "</div>";
        dis.InnerHtml = str;
    }



    //protected void btnAdd_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("VehicleTypeProductEdit.aspx");
    //}
}