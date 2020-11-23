using Microsoft.AspNetCore.Components.Desktop;
using System;

namespace Chilicki.StringLabs
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ComponentsDesktop.Run<Startup>("index.html", form =>
            {
                form.Text = "MyDesktopApp";
            });
        }
    }
}
