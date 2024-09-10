using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GADE
{
    class Game_Engine
    {
        private LeveL theCurrentLevel;
        private int numberOfLevels;

        Random randomNumbers = new Random();
        HeroTile heroCharacter;
        const int MIN_SIZE = 10;
        const int MAX_SIZE = 20;

        LeveL level;
        public Game_Engine(int NumberOfLevels)
        {
            this.numberOfLevels = NumberOfLevels;

            int levelWidth = randomNumbers.Next(MIN_SIZE, MAX_SIZE + 1);
            int levelHeight = randomNumbers.Next(MIN_SIZE, MAX_SIZE + 1);

            HeroTile hero = null;
            theCurrentLevel = new LeveL(levelWidth, levelHeight, hero); //Level object to be used to initialise the 'theCurrentLevel' field 

            Position position = new Position(0, 0);
            heroCharacter = new HeroTile(position);

        }

        public override string ToString()
        {

            return (theCurrentLevel.ToString());
        }

       public enum Direction { Up, Right, Down, Left }

       private bool MoveHero(Direction direction)
        {
            Tile tileTarget = null;
            
        
            if (direction == Direction.Up)
            {
                tileTarget = heroCharacter.characterVision[0];
      
            }
           
            else if (direction == Direction.Right) 
            {
                tileTarget = heroCharacter.characterVision[1];
            }

            else if(direction == Direction.Down)
            {
               tileTarget = heroCharacter.characterVision[2];  
            }
       
           else if (direction == Direction.Left)
           {
                tileTarget = heroCharacter.characterVision[3];
           }
         
            
            if(tileTarget is EmptyTile) 
            {
            
                theCurrentLevel.SwopTiles(heroCharacter, tileTarget);
                heroCharacter.UpdateVision(level);
              
                return true;
            }       
        return false;
               
       }


        public bool TriggerMovement(Direction direction)
        {
            return MoveHero(direction);
        }

    }
}
