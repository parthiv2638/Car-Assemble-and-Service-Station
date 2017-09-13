using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_ServiceHistoryDetails : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            int sum = 0;

            var data = (from t in dc.ServiceDetails
                     //   join tsd in dc.Services on t.Sid equals tsd.Sid
                        join tvn in dc.VehicleType_Products on t.VTypeProid equals tvn.VTypeProid
                        join tp in dc.Products on tvn.Pid equals tp.Pid
                        where t.Sid.Equals(Request.QueryString["Id"])
                        select new
                {
                    t.Sdetailid,
                    t.Sid,
                    t.VTypeProid,
                    t.Sdescripton,
                    t.Price,
                    t.Quantity,
                    tp.Pname,
                    tp.Pimg
                }).ToList();





            string str = "<table class ='table table-bordered table-hover'>";
            str += "<tr><th>Product Name</th><th>Product Image</th><th>Price</th><th>Quantity</th><th>Total Price<th>Service Desc</th></tr>";
            foreach (var item in data)
            {
                int total=int.Parse(item.Price.ToString());
                sum = sum + total;
                //string s = item.IsDone == true ? "Yes" : "No";
                str += "<tr><td>" + item.Pname + "</td><td>  <img src='../Images/" + item.Pimg + "' height ='100px' width ='100px' /></td><td>" + item.Price + "</td><td>" + item.Quantity + "</td><td>" + item.Price * item.Quantity + "</td><td>" + item.Sdescripton + "</td></tr>";
            }
            str += "<tr><td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + sum + "</td><tr>";
            str += "</table>";
            dis.InnerHtml = str;
        }
    }
}
