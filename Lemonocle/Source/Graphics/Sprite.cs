using System.Reflection.Metadata.Ecma335;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Lemonocle.Graphics
{
    public class Sprite
    {
        protected Texture2D texture;
        protected float angle;
        protected Vector2 scale;
        protected Vector2 origin;
        protected SpriteEffects effects;
        protected Color color;

        public Sprite(Texture2D texture)
        {
            this.texture = texture;

            scale = Vector2.One;
            origin = Vector2.Zero;
            angle = 0;
            effects = SpriteEffects.None;
            color = Color.White;
        }

        public Texture2D GetTexture()
        {
            return texture;
        }

        public void SetTexture(Texture2D texture)
        {
            this.texture = texture;
        }

        public float GetAngle() 
        {
            return angle;
        }

        public Vector2 GetScale()
        {
            return scale;
        }
        
        public Vector2 GetOrigin()
        {
            return origin;
        }
        public void SetOrigin(Vector2 origin)
        {
            this.origin = origin;
        }

        public SpriteEffects GetEffects()
        {
            return effects;
        }

        public void SetEffects(SpriteEffects effects)
        {
            this.effects = effects;
        }

        public Color GetColor()
        {
            return color;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }
    }
}