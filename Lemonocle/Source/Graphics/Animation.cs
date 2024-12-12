using Microsoft.Xna.Framework;

namespace Lemonocle.Graphics;

public class Animation
{
    private Sprite sprite;
    private Rectangle srcRect;

    public Animation(Sprite sprite)
    {
        this.sprite = sprite;
        srcRect = new Rectangle(0, 0, 1, 1);
    }

    public Sprite GetSprite()
    {
        return sprite;
    }

    public Rectangle GetSrcRect()
    {
        return srcRect;
    }
}