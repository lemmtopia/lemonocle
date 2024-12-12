using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Lemonocle.Graphics;

public class Sprite
{
    // NOTE: Sprites are not GameObjs, but GameObjs contain Sprites.
    // Properties for drawing control.
    public Texture2D texture;
    public Vector2 origin;
    public Vector2 scale;
    public SpriteEffects effects;
    public Color color;
    public float angle;
    public float layerDepth;

    public Sprite()
    {
        origin = Vector2.Zero;
        scale = Vector2.One;
        effects = SpriteEffects.None;
        color = Color.White;
        angle = 0;
        layerDepth = 0;
    }
}