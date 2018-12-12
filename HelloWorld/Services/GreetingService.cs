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
                Audience = "NDC Oslo",
                Description = "Welcome to the finest developer conference in Oslo!"
            };
        }

        public Task<Greeting> GetGreetingAsync()
        {
            return new Task<Greeting>(() => GetGreeting());
        }
    }
}
