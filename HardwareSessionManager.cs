﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Represents the `workspace` in which the app runs -- I felt the need to use 
 * a separate class from the Form to deal with state
 * 
 */
namespace temaCsharp
{
    public class HardwareSessionManager
    {
        public List<Computer> computers;

        public List<Component> components;

        public HardwareSessionManager()
        {
            computers  = new List<Computer>();
            components = new List<Component>();
        }
    }
}
