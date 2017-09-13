using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_ServicesHistory : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {




//        var data = (from t in dc.Services
//                    join tvn in dc.VehicleNumbers on t.Vnumberid equals tvn.Vnumberid
//                    join tu in dc.Users on t.Userid equals tu.Userid
//                    join tv in dc.Vehicles on tvn.Vid equals tv.Vid
//                    where tu.Userid == int.Parse(Session["Userid"].ToString())
//                    select new
//                    {
//                        t.Sid,
//                        t.Sdescription,
//                        tvn.Vnumber,
//                        tu.Username,
//                        tu.Contno,
//                        tu.Userimg,
//                        tv.Vname,
//                        tv.Vimg,
//                        t.Aregistereddate,
//                        t.Aservicedate,
//                        t.IsDone,
//                        tvn.Vid
//                    }).ToList();





//        string str = "<table class ='table table-bordered table-hover'>";
//        str += "<tr><th>Complete</th><th>Vehicle Name</th><th>Vehicle Number</th><th>Vehicle Photo</th><th>Service Description</th><th>Serv.Registered Date</th><th>Service Date</th><th>Status </th></tr>";
//        foreach (var item in data)
//        {
//            string s = item.IsDone == true ? "Done" : "Pending";
//            str += "<tr><td><a href=ServiceDetails.aspx?Id=" + item.Sid + "&Vid=" + item.Vid + ">Complete</a></td><td>" + item.Vname + "</td><td>" + item.Vnumber +  "</td><td>  <img src='../Images/" + item.Vimg + "' height ='100px' width ='100px' /></td><td>" + item.Sdescription + "</td><td>" + item.Aregistereddate + "</td><td>" +   item.Aservicedate + "</td><td> " + s + "</td></tr>";
//        }
//        str += "</table>";
//        dis.InnerHtml = str;
//    }
//}












        var data = (from t in dc.Services
                    join tvn in dc.VehicleNumbers on t.Vnumberid equals tvn.Vnumberid
                    join tu in dc.Users on t.Userid equals tu.Userid
                    join tv in dc.Vehicles on tvn.Vid equals tv.Vid
                    where tvn.Userid == int.Parse(Session["Userid"].ToString())
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
                        t.IsDone,
                        tvn.Vid
                    }).ToList();





        string str = "<div class='postlist'>";
        foreach (var item in data)
        {
            string s = item.IsDone == true ? "Complete" : "Pending";
            DateTime d1 = Convert.ToDateTime(item.Aregistereddate);
            DateTime d2= Convert.ToDateTime(item.Aservicedate);

            str += "<div class='post-item'>";

            str += "<div class='post-title'>";
            str += "<h2>";
            str += "<a href='ServiceHistoryDetails.aspx?Id=" + item.Sid + "' hidefocus='true' style='outline: medium none;'> "+ item.Vname + "</a>";
            str += "</h2>";
            str += "</div>";

            str += "<div class='post-aside clearfix'>";

            str += "<div class='post-image'>";
            str += "<img src='../Images/" + item.Vimg + "' />";
            str += "</div>";

            str += "<div class='post-meta'>";

            str += "<div class='info_row'>";
            str += "<span>Vehical No:</span>";
            str += item.Vnumber;
            str += "</div>";

            str += "<div class='info_row'>";
            str += "<span>Service Reg Date:</span>";
            str += d1.ToShortDateString();
            str += "</div>";

            str += "<div class='info_row'>";
            str += "<span>Vservice date:</span>";
            str += d2.ToShortDateString();
            str += "</div>";

            str += "<div class='info_row'>";
            str += "<span>Status:</span>";
            str += s;
            str += "</div>";

            str += "<div class='info_row'>";
            str += "<span>Description:</span>";
            str += item.Sdescription;
            str += "</div>";
            str += "</div>";

            str += "</div>";

            str += "</div>";
            //str += "<tr><td><a href=ServiceHistoryDetails.aspx?Id=" + item.Sid + ">Detail</a></td><td>" + item.Vname + "</td><td>" + item.Vnumber + "</td><td>  <img src='../Images/" + item.Vimg + "' height ='100px' width ='100px' /></td><td>" + item.Sdescription + "</td><td>" + item.Aregistereddate + "</td><td>" + item.Aservicedate + "</td><td> " + s + "</td></tr>";
        }
        str += "</div>";
        dis.InnerHtml = str;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Response.Redirect("VehicleTypeProductEdit.aspx");
    }
}