using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.TemperatureReporter reporteador = new Library.TemperatureReporter();
            Library.TemperatureMonitor monitor = new Library.TemperatureMonitor();
            reporteador.Subscribe(monitor);
            monitor.GetTemperature();
        }
    }
}
