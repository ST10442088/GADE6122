using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE
{
    public class HeroTile : CharacterTile
    {
        public HeroTile(Position position) : base(position, 40, 5)
        { }

        public override char Display
        {
            get
            {
                if (isDead == true)
                {
                    return 'X';
                }

                else
                {
                    return '▼';
                }
            }
        }
    }
}


