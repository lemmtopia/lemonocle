using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace Lemonocle.Core;

public class Scene
{
    private List<GameObj> gameObjList;

    public Scene()
    {
        gameObjList = new List<GameObj>();
    }

    public void Draw(SpriteBatch _spriteBatch)
    {
        foreach (GameObj gameObj in gameObjList)
        {
            gameObj.Draw(_spriteBatch);
        }    
    }
}