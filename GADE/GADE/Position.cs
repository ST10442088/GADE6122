using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GADE
{
    public class Position
    {
        private int x_Co_ordinate; 
        private int y_Co_ordinate;

      public  Position tilePosition {  get; set; } 
        public Position(int X_Co_ordinate, int Y_Co_ordinate)
        {
            this.x_Co_ordinate = X_Co_ordinate;
            this.y_Co_ordinate = Y_Co_ordinate;
        }
        
   
        public int Get_x_Co_ordinate
        {
         
            get { return this.x_Co_ordinate; }
            set {  this.x_Co_ordinate = value;}
        }
  
    
       
        public int Get_y_Co_ordinate
        {
            get { return this.y_Co_ordinate;}
            set { y_Co_ordinate = value; }
        }
    
     
    
    }
}
