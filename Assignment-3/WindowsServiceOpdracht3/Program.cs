﻿/*
 *Application name  : Opdracht 3 webservice
 *Author            : Team firefly
*/
namespace WindowsServiceOpdracht3
{
    using System.ServiceProcess;

    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            ServiceBase[] servicesToRun;
            servicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}