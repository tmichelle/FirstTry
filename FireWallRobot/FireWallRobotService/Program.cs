﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace FireWallRobotService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
<<<<<<< HEAD
=======
        /// tesst
>>>>>>> origin/branch1
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new FireWallRobotService() 
			};
            ServiceBase.Run(ServicesToRun);
        }
    }
}
