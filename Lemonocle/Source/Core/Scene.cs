using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lemonocle.Core
{
    public class Scene
    {
        protected ContentManager contentManager;

        protected List<GameObj> gameObjs;
        protected List<Texture2D> textures;

        public Scene()
        {
            gameObjs = new List<GameObj>();
        }

        public virtual void Load(ContentManager contentManager)
        {
            this.contentManager = contentManager;

            // Make texture list
            textures = new List<Texture2D>();
        }

        public void Update(GameTime gameTime)
        {
            foreach (GameObj obj in gameObjs)
            {
                obj.Update(gameTime);
            }
        }

        public virtual void Draw(SpriteBatch _spriteBatch)
        {
            foreach (GameObj obj in gameObjs)
            {
                obj.Draw(_spriteBatch);
            }
        }

        public void Unload()
        {
            foreach (GameObj obj in gameObjs)
            {
                obj.Destroy();
            }
        }
    }
}
