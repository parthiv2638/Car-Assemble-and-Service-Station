using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Workers_TaskSheet : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        //{
        //    //var dataa = (from t in dc.Services where t.Sid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
        //    //if (dataa.Count == 1)
        //    //{
        //    //    if (dataa[0].IsDone == true)
        //    //    {
        //    //        dc.Service_Delete(int.Parse(Request.QueryString["Id"]), System.DateTime.Now, false);
        //    //    }
        //    //    else
        //    //    {
        //    //        dc.Service_Delete(int.Parse(Request.QueryString["Id"]), System.DateTime.Now, true);
        //    //    }
        //    //    // Response.Redirect("OperatorList.aspx");
        //    //}
        //}


        //if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        //{
        //    var datawrk = (from t in dc.WorkTasks where t.WTid.Equals(int.Parse(Request.QueryString["Id"])) select t).ToList();
        //    if (datawrk.Count == 1)
        //    {
        //        if (datawrk[0].Status == true)
        //        {
        //            dc.Task_Delete(int.Parse(Request.QueryString["Id"]), System.DateTime.Now, false);
        //        }
        //        else
        //        {
        //            dc.Task_Delete(int.Parse(Request.QueryString["Id"]), System.DateTime.Now, true);
        //        }
        //        // Response.Redirect("OperatorList.aspx");
        //    }
        //}



        //    var dataw = (from twt in dc.WorkTasks
        //                 join tsd in dc.ServiceDetails on twt.Sdetailid equals tsd.Sdetailid
        //                 join ts in dc.Services on tsd.Sid equals ts.Sid
        //                 join tu in dc.Users on ts.Userid equals tu.Userid
        //                 join tvtp in dc.VehicleType_Products on tsd.VTypeProid equals tvtp.VTypeProid
        //                 join tp in dc.Products on tvtp.Pid equals tp.Pid
        //                 join tvnum in dc.Services on ts.Vnumberid equals tvnum.Vnumberid
        //                 join tv in dc.Vehicles on tvtp.Vid equals tv.Vid
        //                 join tvn in dc.VehicleNumbers on ts.Vnumberid equals tvn.Vnumberid
        //                 where twt.Userid == int.Parse(Session["Userid"].ToString())
        //                 select new
        //                  {
        //                      tv.Vimg,
        //                      tvn.Vnumber,
        //                      tu.Username,
        //                      tu.Userimg,
        //                      tp.Pname,
        //                      tsd.Sdescripton,
        //                      twt.Status,
        //                      twt.WTid,
        //                      ts.Sid
        //                  }).Distinct();



        //    string str = "<table class ='table table-bordered table-hover'>";
        //    str += "<tr><th>Service Details</th><th>Vehicle NUmber</th><th>Vehicle Image</th><th>Customer Image</th><th>Product</th><th>Serv Description</th><th>Status?</th></tr>";
        //    foreach (var item in dataw)
        //    {
        //        string s = item.Status == true ? "Yes" : "No";
        //        str += "<tr><td><a href=WServicesDetails.aspx?Id=" + item.WTid + "&Sid=" + item.Sid + ">Service Details</a></td><td>" + item.Vnumber + "</td><td><img src='../Images/" + item.Vimg + "' height ='100px' width ='100px' /></td><td> <img src='../Images/" + item.Userimg + "' height ='100px' width ='100px'/></td><td>" + item.Pname + "</td><td>" + item.Sdescripton + "</td><td>" + s + "</td></tr>";
        //    }
        //    str += "</table>";
        //    dis.InnerHtml = str;
        //}




        var data = (from t in dc.Services
                    join tvn in dc.VehicleNumbers on t.Vnumberid equals tvn.Vnumberid
                    join tu in dc.Users on t.Userid equals tu.Userid
                    join tv in dc.Vehicles on tvn.Vid equals tv.Vid
                    



                    join tsd in dc.ServiceDetails on t.Sid equals tsd.Sid
                    join twrk in dc.WorkTasks on tsd.Sdetailid equals twrk.Sdetailid
                    where twrk.Userid == int.Parse(Session["Userid"].ToString())
     
                    select new
                    {
                        t.Sid,
                        t.Sdescription,
                        tvn.Vnumber,
                        tu.Username,
                        tu.Contno,
                        tu.Userimg,
                        tv.Vname,
                        tv.Vimg,
                        t.Aregistereddate,
                        t.Aservicedate,
                        t.IsDone,tvn.Vid 
                    }).Distinct();





        string str = "<table class ='table table-bordered table-hover'>";
        str += "<tr><th>Services Details</th><th>Customer Name</th><th>Contact No</th><th>Customer Photo</th><th>Vehicle Number</th><th>Vehicle Name</th><th>Vehicle Photo</th><th>Service Description</th><th>Serv.Registered Date</th><th>Service Date</th></tr>";
        foreach (var item in data)
        {
            //string s = item.IsDone == true ? "Yes" : "No";
            str += "<tr><td><a href=WServicesDetails.aspx?SId=" + item.Sid + "&VId="+item .Vid+">Service Details</a></td><td>" + item.Username + "</td><td>" + item.Contno + "</td><td>  <img src='../Images/" + item.Userimg + "' height ='100px' width ='100px' /></td><td>" + item.Vnumber + "</td><td>" + item.Vname + "</td><td>  <img src='../Images/" + item.Vimg + "' height ='100px' width ='100px' /></td><td>" + item.Sdescription + "</td><td>" + item.Aregistereddate + "</td><td>" + item.Aservicedate + "</td></tr>";
        }
        str += "</table>";
        dis.InnerHtml = str;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Response.Redirect("VehicleTypeProductEdit.aspx");
    }
}
