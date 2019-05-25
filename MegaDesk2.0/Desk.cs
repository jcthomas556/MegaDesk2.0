using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
   public class Desk
   {
      public int Width;
      public int Depth;
      public int NumberOfDrawers;
      public string SurfaceMaterial;

      public Desk(int Width, int Depth, int NumberOfDrawers, string SurfaceMaterial)
      {
         this.Width = Width;
         this.Depth = Depth;
         this.NumberOfDrawers = NumberOfDrawers;
         this.SurfaceMaterial = SurfaceMaterial;
      }
   }
}

