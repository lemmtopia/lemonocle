using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonocle.Core
{
    public class SceneManager
    {
        Scene scene;

        public SceneManager()
        {
            scene = new Scene();
        }

        public void NewScene(Scene sc)
        {
            scene = sc;
        }

        public Scene GetScene()
        {
            return scene;
        }
    }
}
