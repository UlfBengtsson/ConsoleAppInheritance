﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritance.Model.ExClasses
{
    class Snake : Animal, IDanger
    {
        public string DangerInfo()
        {
            throw new NotImplementedException();
        }

        public int DangerLevel()
        {
            throw new NotImplementedException();
        }
    }
}
