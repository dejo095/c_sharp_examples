using System;
using System.Collections.Generic;
using System.Text;

namespace Composition_Example
{
    public class Installer
    {
        private readonly Logger _loger;

        public Installer(Logger loger)
        {
            _loger = loger;
        }

        public void Install()
        {
            _loger.Log("we are installing the appp");

        }
    }
}
