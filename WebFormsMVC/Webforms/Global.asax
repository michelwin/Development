<%@ Application Language="C#" %>

<script runat="server">

    public static void RegisterRoutes(RouteCollection routes)
    {
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        //ignore aspx pages (web forms take care of these)
        routes.IgnoreRoute("{resource}.aspx/{*pathInfo}");

        routes.MapRoute(
            // Route name
            "Default",
            // URL with parameters
            "{controller}/{action}/{id}",
            // Parameter defaults
            new { controller = "home", action = "index", id = "" }, new []{"MVC.Controllers"}
            );
    }

    protected void Application_Start(object sender, EventArgs e)
    {
        RegisterRoutes(RouteTable.Routes);
    }
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
