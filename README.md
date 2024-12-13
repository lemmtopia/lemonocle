# lemonocle
## About
Lemonocle is my game engine for MonoGame projects. You can use it for your own games!

The name is based on Maddy Thorson's Monocle Engine, but it is more simillar to the Rogue Legacy Engine.

## Features
- Sprite and Animation system
- Scenes and GameObjects
- TileMaps (work in progress)

## Using lemonocle
You can just copy the source files to your MonoGame or XNA/FNA project and use it, but how do you actually use it?

## How to actually use lemonocle
Lemonocle is easy to use! You can inherit GameObj, Scene and others to add your custom code. For example, you can inherit Scene to make a Room class that has a built in Map.

```cs
using Lemonocle.Core;
using Lemonocle.World;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace YourGame;

class Room : Scene
{
    private Map map;

    public Room()
    {
        // Make map
        map = new Map();
    }

    public override void Load(ContentManager contentManager)
    {
        this.contentManager = contentManager;

        map.Load(contentManager);
        
        //...
    }

    public override void Draw(SpriteBatch _spriteBatch)
    {
        map.Draw(_spriteBatch);

        base.Draw(_spriteBatch);
    }
}
```