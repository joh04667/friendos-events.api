using System;
using Funq;
using ServiceStack;


namespace friendo.api.App_Start
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Friendo Event Service") { }

        public override void Configure(Container container) 
        {


            // container.Register('oh wait I don't have a database yet')
        }
    }
}
