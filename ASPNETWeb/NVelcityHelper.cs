using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ASPNETWeb
{
    public class NVelcityHelper
    {

        public static string GetHtml(string templatename,object Data)
        {

            VelocityEngine vltengine = new VelocityEngine();

            vltengine.SetProperty(RuntimeConstants.RESOURCE_LOADER, "file");

            vltengine.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, System.Web.Hosting.HostingEnvironment.MapPath("~/templates"));

            vltengine.Init();

            NVelocity.VelocityContext vltcontext = new NVelocity.VelocityContext();         

            vltcontext.Put("data", Data);         

            Template vlttemplate = vltengine.GetTemplate(templatename);

            StringWriter vltWrite = new StringWriter();

            vlttemplate.Merge(vltcontext, vltWrite);

            return vltWrite.GetStringBuilder().ToString();
 
        }

    }
}