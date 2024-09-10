using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GADE
{
    public class LeveL : Tile
    {

        public Tile[,] twoDArray;

        public int levelWidth;
        public int levelHeight;
        HeroTile hero;  
    
        static Position positions;
        public LeveL(int levelWidth, int levelHeight, HeroTile hero) : base(positions)
        {

            this.levelWidth = levelWidth;

            this.levelHeight = levelHeight;

             twoDArray = new Tile[levelWidth, levelHeight];
      
      
            InitialiseTiles();
            Position randomPosition =  GetRandomEmptyPosition();
            this.hero = new HeroTile(randomPosition);
            hero = this.hero;

            twoDArray[randomPosition.Get_x_Co_ordinate, randomPosition.Get_y_Co_ordinate] = this.hero;

        }

        public HeroTile Hero
        {
              get  { return this.hero; } 
        }


      /*  public void SetLevelWidth(int levelWidth)
        {
            this.levelWidth = levelWidth;
        }

        public int GetLevelWidth()
        {
            return this.levelWidth;
        }

        public void SetLevelHeight(int levelHeight)
        {
            this.levelHeight = levelHeight;
        }

        public int GetLevelHeight()
        {
            return this.levelHeight;
        } */


        enum TileType { Empty, Wall, Hero }

        public class EmptyTileCreation : Tile
        {
            Position pos;
            public EmptyTileCreation(Position pos) : base(pos)
            {
                this.pos = pos;
            }
            public override char Display { get; }

        }

        Tile CreateTile(TileType tile, Position pos)
        {
          
            switch (tile)
            {
                case TileType.Empty:
                    {
                     
                       return new EmptyTile(pos);
                    }

                case TileType.Wall:
                    {
                        return new WallTile(pos);
                    }
                case TileType.Hero:
                    {
                        return new HeroTile(pos);
                    }
                default:
                    // If the TileType returned is not valid, the statement below will throw an exception that will display "Invalid TileType"
                    throw new ArgumentException("Invalid TileType");

            }

        }


        private Tile CreateTile(TileType tileType, int x, int y)
        {
            Position pos = new Position(x, y);
            return CreateTile(tileType, pos);
        }


        public void InitialiseTiles()
        {


            for (int X_Co_ordinate = 0; X_Co_ordinate < levelWidth; X_Co_ordinate++)
            {
                for (int Y_Co_ordinate = 0; Y_Co_ordinate < levelHeight; Y_Co_ordinate++)
                {

                    if (X_Co_ordinate == levelWidth - 1 || Y_Co_ordinate == levelHeight - 1 || X_Co_ordinate == 0 || Y_Co_ordinate == 0)
                    {
                         twoDArray[X_Co_ordinate, Y_Co_ordinate] = CreateTile(TileType.Wall, new Position(X_Co_ordinate, Y_Co_ordinate));  // As long as the loop stays within the array row bounds, create the wall tiles
                    }

                     else
                     {
                         twoDArray[X_Co_ordinate, Y_Co_ordinate] = CreateTile(TileType.Empty, new Position(X_Co_ordinate, Y_Co_ordinate));
                     } 
                    
                }
            }
        }


        public override char Display => '.'; //return the '.' char

        public override string ToString()
        {

          
            string dots = "";

            for (int Y_Co_ordinate = 0; Y_Co_ordinate < levelHeight; Y_Co_ordinate++)
            {
                for (int X_Co_ordinate = 0; X_Co_ordinate < levelWidth; X_Co_ordinate++)

                {
                    dots = dots + twoDArray[X_Co_ordinate, Y_Co_ordinate].Display; 
                }

                dots = dots + "\n";

            }
            return dots;
        }

        private Position GetRandomEmptyPosition()
        {
            Random random = new Random();
            Position randomPosition;
            int X_Co_Ordinate;
            int Y_Co_Ordinate;
            do
            {
                X_Co_Ordinate = random.Next(1, levelWidth - 1);  //The x co ordinate is equal to the result of the random roll between 1 and a row tile above
                Y_Co_Ordinate = random.Next(1, levelHeight - 1); //The y co ordinate is equal to the result of the random roll between 1 and a column above
                randomPosition = new Position(X_Co_Ordinate, Y_Co_Ordinate); //The above results are given as parameters to the Position class

            } while ((twoDArray[randomPosition.Get_x_Co_ordinate, randomPosition.Get_y_Co_ordinate] is EmptyTile) == false); //While the rows/columns in the array are not empty
                          
            return randomPosition;
        }
   
        public void SwopTiles(Tile tileOne, Tile tileTwo)
        {
            Position firstPosition = tileOne.tilePosition;

            Position secondPosition = tileTwo.tilePosition;
        

            twoDArray[  firstPosition.Get_x_Co_ordinate, firstPosition.Get_y_Co_ordinate] = tileOne; //Initializing the array with the now swapped tile of tileOne, placing it where tileTwo once was
            twoDArray[secondPosition.Get_x_Co_ordinate, secondPosition.Get_y_Co_ordinate] = tileTwo; //Initializing the array with the now swapped tile of tileTwo, placing it where tileOne once was

            //Updating the positions od the tiles
            tileOne.tilePosition = secondPosition;
            tileTwo.tilePosition = firstPosition;

        }

     enum Direction {Up, Right, Down, Left,None }

    
    
    }

}

