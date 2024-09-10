using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE
{


    class EmptyTile : Tile
    {

       public EmptyTile(Position position) : base(position) //Constructor that passses the Position parameter back to the base class constructor
       { 
            
       }  

        public override char Display
        {
            get { return '.'; }        
        }

    }
}
