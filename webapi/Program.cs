using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Demo
{

    public class Program
    {

        public static void Main(string[] args)
        {
            var host = new WebhostBuider()
                .UseKestrel()
                .UseControlRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>();

            host.Run();
        }
    }
}


