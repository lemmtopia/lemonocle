using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

namespace Lemonocle.Graphics
{
    public class Animation
    {
        Sprite sprite;
        int frameCount;
        float frameTime;
        int curFrame;
        int frameWidth;

        Rectangle srcRect;

        public Animation(int frameCount, Sprite sprite)
        {
            this.sprite = sprite;
            curFrame = 0;
            frameTime = 0;

            this.frameCount = frameCount;

            frameWidth = sprite.GetTexture().Width / frameCount;
            srcRect = new Rectangle(0, 0, frameWidth, sprite.GetTexture().Height);
        }

        public void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (frameCount > 1)
            {
                frameTime += dt;
            }

            if (frameTime >= 0.1f)
            {
                curFrame++;
                frameTime = 0;
            }

            if (curFrame >= frameCount)
            {
                curFrame = 0;
            }

            srcRect.X = curFrame * frameWidth;
        }

        public Sprite GetSprite()
        {
            return sprite;
        }

        public int GetFrameCount()
        {
            return frameCount;
        }

        public void SetFrameCount(int newFrameCount)
        {
            frameCount = newFrameCount;

            // reset anim
            curFrame = 0;
        }

        public Rectangle GetSrcRect()
        {
            return srcRect;
        }
    }
}