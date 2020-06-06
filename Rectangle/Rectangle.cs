using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
 
namespace Rectangle
{
    public class Rectangle
    {
        private int length;
        private int width;
        private int rectanglePerimeter;
        private int rectangleArea;
        public int Length
        {
            get => length;set => length = value;
        }
        public int Width
        {
            get => width; set => width = value;
        }

        public Rectangle()
        {
            this.Length = 1;
            this.Width = 1;
        }
        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }

        public int GetLength()
        {
            return this.Length;
        }

        public int SetLength(int length)
        {
            this.Length = length;
            return this.Length;
        }

        public int GetWidth()
        {
            return this.Width;
        }

        public int SetWidth(int width)
        {
            this.Width = width;
            return this.Width;
        }

        public int GetPerimeter()
        {
            rectanglePerimeter = 2 * (this.Length + this.Width);
            return rectanglePerimeter;
        }

        public int GetArea()
        {
            rectangleArea = this.Length * this.Width;
            return rectangleArea;
        }

    }
}