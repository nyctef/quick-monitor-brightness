using System;
using System.Diagnostics;

namespace monitor_brightness
{
    class Program
    {
        static int Main(string[] args)
        {
            int brightness;

            if (args.Length != 1 || !int.TryParse(args[0], out brightness))
            {
                Console.WriteLine("Usage: monitor_brightness [brightness as percentage]");
                return 1;
            }

            BrightnessController.SetBrightness((uint)brightness);


            return 0;
        }
    }
}
