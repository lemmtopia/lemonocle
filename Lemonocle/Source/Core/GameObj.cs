using System;
using Lemonocle.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Lemonocle.Core;

public class GameObj
{
    protected Vector2 position;
    protected Animation animation;

    public GameObj(Vector2 position)
    {
        // Start by setting my position and nothing more.
        this.position = position;
    }

    public void Draw(SpriteBatch _spriteBatch)
    {
        if (animation.GetSprite().texture == null)
        { 
            // Don't draw
            return;
        }

        _spriteBatch.Draw(
            animation.GetSprite().texture,
            position,
            animation.GetSrcRect(),
            animation.GetSprite().color,
            animation.GetSprite().angle,
            animation.GetSprite().origin,
            animation.GetSprite().scale,
            animation.GetSprite().effects,
            animation.GetSprite().layerDepth);
    }
}