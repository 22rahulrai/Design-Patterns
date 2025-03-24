using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Media_adapter : Imediaplayer
    {
        private readonly Oldmediaplayer oldmp;
        private readonly Advancedmediaplayer advancedmp;

        public Media_adapter()
        {
            oldmp = new Oldmediaplayer();
            advancedmp = new Advancedmediaplayer();
        }
        public void Play(string audiotype,string filename)
        {
            if (audiotype.Equals("MP3",StringComparison.OrdinalIgnoreCase))
            {
                oldmp.PlayMp3(filename);
            }
            else if (audiotype.Equals("MP4", StringComparison.OrdinalIgnoreCase))
            {
                advancedmp.PlayMP4(filename);
            }
            else if (audiotype.Equals("VLC", StringComparison.OrdinalIgnoreCase))
            {
                advancedmp.PlayVLC(filename);
            }
            else
            {
                Console.WriteLine("Invalid file format: "+audiotype);
            }
        }
    }
}
