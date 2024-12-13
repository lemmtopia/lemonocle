using System;
using Lemonocle.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Lemonocle.Core
{
    public class GameObj
    {
        protected Vector2 position;
        protected Vector2 velocity;

        // The sprite is stored in the animation
        protected Animation animation;

        public GameObj(Vector2 position)
        {
            this.position = position;   
        }

        public void SetAnimation(Texture2D texture, int frameCount)
        {
            Sprite sprite = new Sprite(texture);
            animation = new Animation(frameCount, sprite);
        }

        public virtual void Update(GameTime gameTime)
        {
            // Update my position
            position += velocity;
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            if (animation.GetSprite().GetTexture() == null)
            {
                // Do not draw
                return;
            }

            // Draw with all the parameters possible
            _spriteBatch.Draw(
                animation.GetSprite().GetTexture(), 
                position, 
                animation.GetSrcRect(), 
                animation.GetSprite().GetColor(), 
                animation.GetSprite().GetAngle(),
                animation.GetSprite().GetOrigin(), 
                animation.GetSprite().GetScale(), 
                animation.GetSprite().GetEffects(),
                0);
        }

        public virtual void Destroy()
        {
            animation.GetSprite().GetTexture().Dispose();
        }
    }
}
