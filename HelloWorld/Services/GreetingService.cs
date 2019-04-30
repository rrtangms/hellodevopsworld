using System;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public class GreetingService
    {
        public Greeting GetGreeting()
        {
            return new Greeting()
            {
                Salutation = "Hello",
                Audience = "World",
                Description = "Welcome to your new app"
            };
        }

        public Task<Greeting> GetGreetingAsync()
        {
            return new Task<Greeting>(() => GetGreeting());
        }
    }
}
