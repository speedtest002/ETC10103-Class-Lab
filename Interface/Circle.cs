﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Interface
{
   internal class Circle : DrawingShape, IDraw, IColor
   {

      public Circle(int sideLength) :base(sideLength)
      {
      }
      public override void Draw(Canvas canvas)
      {
         if (this.shape != null)
         {
            canvas.Children.Remove(this.shape);//Xóa đối tượng
         }
         else
         {
            this.shape = new Ellipse();
         }
         base.Draw(canvas);
      }
   }
}
