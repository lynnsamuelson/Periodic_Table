using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using ElementApi.Models;

namespace SimpleApi.Controllers
{
    [Route("api/[Element]")]
    public class ElementController : Controller
    {
        [FromServices]
        public IElementRepository ElementItems { get; set; }

    [HttpGet]
    public IEnumerable<AtomicElement> GetAll()
    {
        return ElementItems.GetAll();
    }

    [HttpGet("{id}", Name = "GetElement")]
    public IActionResult GetById(string id)
    {
        var item = AtomicElement.FindElement();
        if (item == null)
        {
            return HttpNotFound();
        }
        return new ObjectResult(item);
    }
}
}