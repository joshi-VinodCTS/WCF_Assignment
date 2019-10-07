using System.ServiceModel;
using System.Web.Mvc;
using TestClientMvcApp.HttpServiceReference;
using TestClientMvcApp.Models;

namespace TestClientMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BasicHttp()
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            ViewBag.Message = client.SayHello("Kaushik");
            return View();
        }

        [HttpPost]
        public ActionResult NetTcp()
        {
            /*Service1Client client = new Service1Client("NetTcpBinding_IService1");
            ViewBag.Message = client.TodayProgram("Kaushik");
            return View();*/


            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
            EndpointAddress address = new EndpointAddress("net.tcp://localhost:8089/TestServiceLibrary/Service1/netTCP");

            ChannelFactory<IService1> channelFactory = new ChannelFactory<IService1>(binding, address);
            IService1 _clientProxy = channelFactory.CreateChannel();

            ViewBag.Message = _clientProxy.TodayProgram("Kaushik");
            return View();
        }
    }
}