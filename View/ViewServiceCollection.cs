using Microsoft.Extensions.DependencyInjection;
using View.Scene;
using View.Scene.Interfaces;
using View.Window;
using View.Window.Interfaces;

namespace View
{
    public static class ViewServiceCollection
    {
        public static ServiceCollection GetServiceCollection()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IScene, GameScene>();
            serviceCollection.AddTransient<IWindow, GameWindow>();

            return serviceCollection;
        }
    }
}
