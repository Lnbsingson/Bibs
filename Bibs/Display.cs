using System;
using System.Collections.Generic;
using System.Text;

namespace Bibs
{
    class Display
    {
        private Display[] RGBD;
        public Display(int length,int pixels, params int[] RGB)
        {
            RGBD = new Display[length];
            for(int i = 0; i < RGB.Length; i++)
            {
                RGBD[i] = new Display(RGB[i], length);
            }

        }
        public Display[] GetDisplays
        {
            get { return RGBD; }
        }
      
        
    }
}
