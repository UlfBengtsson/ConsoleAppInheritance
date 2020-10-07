using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritance.Model.ExClasses
{
    class Tool : IDanger
    {

        int dangerLevel;

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
