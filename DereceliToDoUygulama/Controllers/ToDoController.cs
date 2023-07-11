using DereceliToDoUygulama.Model;
using Microsoft.AspNetCore.Mvc;

namespace DereceliToDoUygulama.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private static readonly IEnumerable<ToDoModel> ToDoList = new[] 
        {
            new ToDoModel { Id=1,Title ="Ödev", Comment ="Matematik sayfa 13 ", Ranked= "Önemli",Type ="Okul"}
        }
       
    }
}
