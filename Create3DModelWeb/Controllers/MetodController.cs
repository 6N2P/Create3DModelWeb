using Create3DModelWeb.Models;
using Creator;
using Microsoft.AspNetCore.Mvc;

namespace Create3DModelWeb.Controllers
{
    public class MetodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> CreateCub(ValuesModel values)
        {
            var client = new Creator.CreatorClient(CreatorClient.EndpointConfiguration.BasicHttpBinding_ICreator);
            ValuesModel v = new ValuesModel();
            v.height = values.height;
            v.width = values.width;
            v.thickness = values.thickness;
            v.calculation = await client.CreateCubAsync(values.height, values.width, values.thickness);

            ViewBag.Calcul = v.calculation;
            if (ModelState.IsValid)
            {
                return View("Index");
            }

            client.Close();
            return View("Index");
        }
    }
}
