using Microsoft.AspNetCore.Mvc;
using System.Collections;
using webapi.Models;
using WebUI.Context;
using System.Web.Http.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(origins: "*", headers: "*", methods: "get,post")]
    public class CadastroController : ControllerBase
    {

        private readonly BancoContext db;

        public CadastroController(BancoContext context)
        {
            db = context;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<TB_CADASTRO> Get()
        {
            return db.TB_CADASTRO.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ObjectResult Get(string id)
        {
            var dados = db.TB_CADASTRO.Find(Guid.Parse(id));
            return Ok(dados);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] TB_CADASTRO model)
        {
            if(model.ID_REGISTRO == Guid.Empty)
            {
                model.ID_REGISTRO = Guid.NewGuid();
                model.NRO_INSCRICAO = db.TB_CADASTRO.Max(x => x.NRO_INSCRICAO) + 1;
                model.DATA_INSCRICAO = DateTime.Now;
                db.TB_CADASTRO.Add(model);
                db.SaveChanges();
            }

            db.TB_CADASTRO.Update(model);
            db.SaveChanges();

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var cadastro = db.TB_CADASTRO.Find(Guid.Parse(id));

            if(cadastro != null)
            {
                db.TB_CADASTRO.Remove(cadastro);
                db.SaveChanges();
            }

        }
    }
}
