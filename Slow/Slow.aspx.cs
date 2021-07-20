using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
	{
        Trace.Write("[Page Trace]Page load begin Trace Begin");
        Response.Write("<p>Sleeping.....<p>");
        Trace.Warn("Entering Sleep for 60 seconds ..awwwwwww");
        System.Threading.Thread.Sleep(20000);
        Trace.Write("Page Load complete");
    } 
}