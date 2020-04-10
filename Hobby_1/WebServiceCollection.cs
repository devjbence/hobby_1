using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Hobby_1
{
    public static class WebServiceCollection
    {
        public static ServiceCollection GetServiceCollection()
        {
            var collection = new ServiceCollection();

            return collection;
        }
    }
}
