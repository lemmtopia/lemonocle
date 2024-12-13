using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Lemonocle.Input
{
    public class InputManager
    {
        public static int GetKeyAsInt(KeyboardState kbState, Keys key)
        {
            // convert to int
            return kbState.IsKeyDown(key) ? 1 : 0;
        }
        
        public static int GetAxis(KeyboardState kbState, Keys keyPositive, Keys keyNegative)
        {
            int positive = GetKeyAsInt(kbState, keyPositive);
            int negative = GetKeyAsInt(kbState, keyNegative);
            return positive - negative;
        }
    }
}