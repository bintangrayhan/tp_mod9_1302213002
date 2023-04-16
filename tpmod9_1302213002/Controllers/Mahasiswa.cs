using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;
using tpMod9_1302213002;
using tpMod9_1302213002.Pages;

namespace tpMod9_1302213002.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : ControllerBase
    {
        public static List<Mahasiswaa> _data = new List<Mahasiswaa>
        {
            new Mahasiswaa("bintang geming", "1302210094"),
            new Mahasiswaa("ariel", "1302210700"),
            new Mahasiswaa("yakuo", "1302210800"),
            new Mahasiswaa("zinet", "13022105989"),
            new Mahasiswaa("fajar", "13022107987"),
        };
        // GET: api/<Mahasiswa>
        [HttpGet]
        public IEnumerable<Mahasiswaa> Get()
        {
            return _data;
        }

        // GET api/<Mahasiswa>/5
        [HttpGet("{id}")]
        public Mahasiswaa Get(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            return _data[id];
        }

        // POST api/<Mahasiswa>
        [HttpPost]
        public void Post([FromBody] Mahasiswaa value)
        {
            _data.Add(value);
        }
        // DELETE api/<Mahasiswa>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            _data.RemoveAt(id);
        }
    }
}