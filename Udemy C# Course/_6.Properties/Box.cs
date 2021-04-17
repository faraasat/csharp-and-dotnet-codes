using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Properties
{
    class Box
    {

        private int length;
        private int height;
        private int width;
        private int volume;

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        // Long approach
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0) throw new Exception("Size should be positive");
                length = value;
            }
        }

        // Modern Approach
        public int Height { get; set; }  // We can also use property without variable and also called auto implemented property

        // Another Approach
        public int Width { 
            get => width; 
            set => width = value; 
        }

        // Read only Property    -- There is also a write only property
        public int Volume
        {
            get => length * Width * Height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2} so, the volume is {3}", length, Height, Width, length*Width*Height);
        }

    }
}
