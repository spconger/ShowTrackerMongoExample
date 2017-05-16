using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Venues v = new Venues();
        List<Venue> vs = v.GetVenues();
        DataList1.DataSource = vs;
        DataList1.DataBind();
    }
}