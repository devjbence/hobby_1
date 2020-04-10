using System;
using Serilog;
using View.Scene.Interfaces;
using View.Window.Interfaces;

namespace View.Window
{
    public class GameWindow : IWindow
    {
        private readonly IScene _scene;
        private readonly ILogger _logger;

        public GameWindow(IScene scene, ILogger logger)
        {
            _scene = scene;
            _logger = logger;
        }

        public void Test()
        {
            Console.WriteLine("Widnow DI WORKS");
            _scene.Test();
            _logger.Information("Loginfo");
        }
    }
}
