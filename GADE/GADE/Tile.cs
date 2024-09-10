using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE
{
    public abstract class Tile
    {
        
        private Position position;


        public Tile(Position positions)
        {
            this.position = positions;
        }


        public int X_Co_Oridinate
        {
           
            get{ return position.Get_x_Co_ordinate; }
        }

        public int Y_Co_Ordinate
        {
            get { return position.Get_y_Co_ordinate; }
        }

       public abstract char Display
       { 
            get;
       }
   
    public Position tilePosition { get; set; }
    }
}