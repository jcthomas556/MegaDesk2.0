using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
   public class Desk
   {
      public decimal Width;
      public decimal Depth;
      public decimal NumberOfDrawers;
      public string SurfaceMaterial;

      public Desk(decimal Width, decimal Depth, decimal NumberOfDrawers, string SurfaceMaterial)
      {
         this.Width = Width;
         this.Depth = Depth;
         this.NumberOfDrawers = NumberOfDrawers;
         this.SurfaceMaterial = SurfaceMaterial;
      }
   }
}

