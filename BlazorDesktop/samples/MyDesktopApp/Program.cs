﻿using Microsoft.AspNetCore.Components.Desktop;
using System;

namespace MyDesktopApp
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
