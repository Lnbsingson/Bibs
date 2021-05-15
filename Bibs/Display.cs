using System;
using System.Collections.Generic;
using System.Text;

namespace Bibs
{
    class Display
    {
        public int size;
        public string color;

        public Display()
        {
            this.size = 0;
            this.color = null;
        }
        public Display(int Size)
        {
            this.size = Size;
            this.color = null;
        }
        public Display(int Size, string Color)
        {
            this.size = Size;
            this.color = Color;
        }
        
        public int getSize
        {
            get { return size; }
            set { this.size = value; }
        }
        public string getcolor
        {
            get { return color; }
            set { this.color = value; }
        }

    }
}
