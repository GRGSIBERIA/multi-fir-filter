using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace MultiFIR.Library
{
    public class ASIOProvider
    {
        AsioOut asio;

        public ASIOProvider(string driverName)
        {
            asio = new AsioOut(driverName);
        }
    }
}
