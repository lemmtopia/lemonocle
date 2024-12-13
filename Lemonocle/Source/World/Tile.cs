using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonocle.World
{
    public class Tile
    {
        public bool isCollidable;
        private Rectangle collisionRect;
        private Rectangle srcRect;          // For finding the tile in tileset

        public Tile(bool isCollidable, Rectangle collisionRect, Rectangle srcRect)
        {
            this.isCollidable = isCollidable;
            this.collisionRect = collisionRect;
            this.srcRect = srcRect;
        }

        public Rectangle GetCollisionRect()
        {
            return collisionRect;
        }

        public Rectangle GetSrcRect()
        {
            return srcRect;
        }
    }
}
