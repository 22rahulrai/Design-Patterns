using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    class Advancedmediaplayer
    {
        public void PlayMP4(string filename)
        {
            Console.WriteLine($"Playing MP4 file: {filename}");
        }

        public void PlayVLC(string fileName)
        {
            Console.WriteLine($"Playing VLC file: {fileName}");
        }
    }
}
