using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class token1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Request.QueryString.AllKeys.Contains("token"))
        {
            Response.ClearHeaders();
            Response.ClearContent();
            Response.Status = "503 ServiceUnavailable";
            Response.StatusCode = 503;
            Response.StatusDescription = "An error has occurred";
            Response.Flush();
            throw new HttpException(503, string.Format("An internal error occurred in the Application on {0}", Environment.MachineName));
        }
        else
        {
            Response.ClearHeaders();
            Response.ContentType = "application/json";
            Response.Write("{\"auth_id\":\"wfeierab\", \"org_name\":\"InfoWorker\", \"org_id\":\"InfoWorker\", \"roles\":[\"Admin\", \"Report Viewer\"]}");
        }
    }
}