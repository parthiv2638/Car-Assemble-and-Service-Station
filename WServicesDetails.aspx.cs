using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Workers_WServicesDetails : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            var dataa = (from t in dc.WorkTasks where t.WTid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
            if (dataa.Count == 1)
            {
                if (dataa[0].Status == true)
                {
                    dc.Task_Delete(int.Parse(Request.QueryString["Id"]), System.DateTime.Now, false);
                }
                else
                {
                    dc.Task_Delete(int.Parse(Request.QueryString["Id"]), System.DateTime.Now, true);
                }
                // Response.Redirect("VehicleTypeProductList.aspx");
            }




            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                var dataser = (from t in dc.Services where t.Sid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
                if (dataser.Count == 1)
                {
                    if (dataser[0].IsDone == true)
                    {
                        dc.Service_Delete(int.Parse(Request.QueryString["Id"]), System.DateTime.Now, false);
                    }
                    else
                    {
                        dc.Service_Delete(int.Parse(Request.QueryString["Id"]), System.DateTime.Now, true);
                    }
                    // Response.Redirect("OperatorList.aspx");
                }
            }
        }


        var dataw = (from twt in dc.WorkTasks
                     join tsd in dc.ServiceDetails on twt.Sdetailid equals tsd.Sdetailid
                     join ts in dc.Services on tsd.Sid equals ts.Sid
                     join tu in dc.Users on ts.Userid equals tu.Userid
                     join tvtp in dc.VehicleType_Products on tsd.VTypeProid equals tvtp.VTypeProid
                     join tp in dc.Products on tvtp.Pid equals tp.Pid
                     join tvnum in dc.Services on ts.Vnumberid equals tvnum.Vnumberid
                     join tv in dc.Vehicles on tvtp.Vid equals tv.Vid
                     join tvn in dc.VehicleNumbers on ts.Vnumberid equals tvn.Vnumberid
                     // where twt.Userid == int.Parse(Session["Userid"].ToString())
                     where tsd.Sid.Equals(int.Parse(Request.QueryString["SId"]))
                     select new
                      {
                          tv.Vimg,
                          tvn.Vnumber,
                          tu.Username,
                          tu.Userimg,
                          tsd.Sdescripton,
                          twt.Status,
                          twt.WTid,
                          ts.Sid,
                          tp.Pname,
                          tp.Pimg,
                      }).Distinct();





        string str = "<table class ='table table-bordered table-hover'>";
        int i = 0;
        foreach (var item in dataw)
        {
            string s = item.Status == true ? "Compelte" : "Assign";
            if (i % 3 == 0)
            {
                str += "<tr></tr>";
            }
            str += "<td> <img src='../Images/" + item.Pimg + "' height ='100px' width ='100px' /><br/>" + item.Pname + "<br/>   <a href=WServicesDetails.aspx?Id=" + item.WTid + "&Sid=" + item.Sid + ">Task:" + s + " </a></td>";
            i++;
        }
        str += "</table>";
        DisProduct.InnerHtml = str;
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        dc.Service_Delete(int.Parse(Request.QueryString["SId"]), System.DateTime.Now, true);
        Response.Redirect("TaskSheet.aspx");
    }
}
