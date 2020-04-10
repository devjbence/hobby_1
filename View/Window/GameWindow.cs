using System;
using View.Scene.Interfaces;
using View.Window.Interfaces;

namespace View.Window
{
    public class GameWindow : IWindow
    {
        private readonly IScene _scene;

        public GameWindow(IScene scene)
        {
            _scene = scene;
        }

        public void Test()
        {
            Console.WriteLine("Widnow DI WORKS");
            _scene.Test();
        }
    }
}
