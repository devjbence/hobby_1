using Microsoft.Extensions.DependencyInjection;

namespace View
{
    public static class ViewServiceCollection
    {
        public static ServiceCollection GetServiceCollection()
        {
            var serviceCollection = new ServiceCollection();

            return serviceCollection;
        }
    }
}
