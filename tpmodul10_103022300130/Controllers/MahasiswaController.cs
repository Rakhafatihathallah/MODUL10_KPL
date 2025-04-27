using Microsoft.AspNetCore.Mvc;
using tpModul10_103022300130.Model;
using tpModul10_103022300130.Data;
using System.Collections.Generic;
using System.Linq;
using tpModul10_103022300130.Model;

namespace tpModul10_103022300001.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        // GET api/mahasiswa
        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll()
        {
            return Ok(DataStore.MahasiswaList);
        }

        // GET api/mahasiswa/{nim}
        [HttpGet("{nim}")]
        public ActionResult<Mahasiswa> GetByNim(string nim)
        {
            var m = DataStore.MahasiswaList.FirstOrDefault(x => x.Nim == nim);
            if (m == null) return NotFound();
            return Ok(m);
        }

        // POST api/mahasiswa
        [HttpPost]
        public ActionResult<Mahasiswa> Create([FromBody] Mahasiswa mahasiswa)
        {
            DataStore.MahasiswaList.Add(mahasiswa);
            return CreatedAtAction(nameof(GetByNim), new { nim = mahasiswa.Nim }, mahasiswa);
        }

        // DELETE api/mahasiswa/{nim}
        [HttpDelete("{nim}")]
        public IActionResult Delete(string nim)
        {
            var m = DataStore.MahasiswaList.FirstOrDefault(x => x.Nim == nim);
            if (m == null) return NotFound();
            DataStore.MahasiswaList.Remove(m);
            return NoContent();
        }
    }
}
