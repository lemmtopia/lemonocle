using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonocle.World
{
    public class Map
    {
        public Texture2D tileset;
        private List<Tile> tileList;

        public Map()
        {
            tileList = new List<Tile>();
        }

        public void Load(ContentManager contentManager)
        {
            tileset = contentManager.Load<Texture2D>("rpg-pack/atlas");
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            foreach (Tile tile in tileList)
            {
                _spriteBatch.Draw(tileset, tile.GetCollisionRect(), tile.GetSrcRect(), Color.White);
            }
        }

        public void AddTile(Tile tile)
        {
            tileList.Add(tile);
        }

        public void Unload()
        {
            tileList.Clear();
            tileset.Dispose();
        }

        public List<Tile> GetTileList()
        {
            return tileList;
        }
    }
}
