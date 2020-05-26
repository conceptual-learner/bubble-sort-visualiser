using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort_visualizer
{
    interface ISortEngine
    {
        void DoWork(int[] TheArray, Graphics g, int MaxVal);
    }
}
