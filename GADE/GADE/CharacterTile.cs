using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GADE
{
    public abstract class CharacterTile : Tile
    {
        public int hitPoints;
        public int maxHitPoints;
        public int attackPower;

       public Tile[] characterVision;
        Position position;
        
        public CharacterTile(Position position, int HitPoints, int AttackPower) : base(position)
        {
            HitPoints = 40;
            AttackPower = 5;
            this.hitPoints = HitPoints;
            this.attackPower = AttackPower;
            
            characterVision = new Tile[4];
        }

        public void UpdateVision(LeveL level)
        {

            int x_Co_ordinate = position.Get_x_Co_ordinate;
            int y_Co_ordinate = position.Get_y_Co_ordinate;

            if (y_Co_ordinate - 1 >= 0)  //Checks to see if there's a row above the character
            {
                characterVision[0] = level.twoDArray[x_Co_ordinate, y_Co_ordinate - 1];
            }

            else
            {
                characterVision[0] = null;
            }

            if (y_Co_ordinate + 1 < level.twoDArray.GetLength(1)) //GetLength(1) will return the number of rows in the twoDArray. The if statement checks to see if there's a row below the character
            {
                characterVision[1] = level.twoDArray[x_Co_ordinate, y_Co_ordinate + 1];
            }

            else
            {
                characterVision[1] = null;
            }

            if (x_Co_ordinate -1 >= 0)  //If there's a column on the left of the character
            {
                characterVision[2] = level.twoDArray[x_Co_ordinate-1, y_Co_ordinate];
            }

            else
            {
                characterVision[2] = null;
            }

            if (x_Co_ordinate + 1 < level.twoDArray.GetLength(0))  //GetLength(0) will return the number of columns in the twoDAArrray. The if statement checks if there's a column below the character
            {
                characterVision[3] = level.twoDArray[x_Co_ordinate + 1, y_Co_ordinate];

            }

            else
            {
                characterVision[3] = null;
            } 
        
        }
   
       public void TakeDamage(int attackPower)
       {
          
            attackPower = this.attackPower;
            if (this.hitPoints > 0)
            {
                this.hitPoints = this.hitPoints - attackPower;
            }

            else { hitPoints = 0; } 
        }
    
       public void Attack(CharacterTile character)
       {
           character.TakeDamage(attackPower);
       }
   
    

       public bool isDead
        {
            get { return hitPoints <= 0; }
        }

    


    }
}
