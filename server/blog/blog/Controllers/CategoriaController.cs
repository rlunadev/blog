using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Data;
using blog.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    [Route("api/[controller]")]
    public class CategoriaController : Controller
    {
        Repository _repository = Repository.Instance;
        // GET api/categoria
        [HttpGet]
        // [EnableCors("AllowSpecificOrigin")]
        public IEnumerable<Categoria> Get()
        {
            return _repository.GetAllCategorias();
        }

        // GET api/categoria/5
        [HttpGet("{id}")]
        public Categoria Get(Guid id)
        {
          return _repository.GetCategoria(id);
        }

        // POST api/categoria
        [HttpPost]
        public void Post([FromBody]Categoria model)
        {
          _repository.AddCategoria(model);
        }

        // PUT api/categoria/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Categoria model)
        {
          _repository.UpdateCategoria(model);
        }

        // DELETE api/categoria/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
          _repository.DeleteCategoria(id);
        }
    }
}
