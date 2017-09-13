using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AMasterPage : System.Web.UI.MasterPage
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        var datav = (from t in dc.Vehicles
                     select t).ToList();
        lblVehcl.Text = datav.Count.ToString();



        var dataa = (from t in dc.Services
                     where t.Aregistereddate==System.DateTime.Now
                     select t).ToList();
        lblAppointment.Text = dataa.Count.ToString();



        var datac = (from t in dc.Users
                     where t.Did == 3
                     select t).ToList();
        lblCust.Text = datac.Count.ToString();




        var datapuser = (from t in dc.PackageDetails
                     select t).ToList();
        lblPachUsers.Text = datapuser.Count.ToString();

    }
}
