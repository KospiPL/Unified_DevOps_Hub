using Microsoft.AspNetCore.Mvc;
using Unified_DevOps_Hub;
using System.Linq;
using Unified_DevOps_Hub.Class;
using Unified_DevOps_Hub.Api.Unified_DevOps_Hub.Api.Dbcontxt;
using Microsoft.EntityFrameworkCore;

namespace Unified_DevOps_Hub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UżytkownicyController : ControllerBase
    {
        private readonly UzytkownicyContext _context;

        public UżytkownicyController(UzytkownicyContext context)
        {
            _context = context;
        }

        // GET: api/Użytkownicy
        [HttpGet]
        public ActionResult<IEnumerable<Użytkownicy>> GetUżytkownicy()
        {
            return _context.Użytkownicy.ToList();
        }

        // GET: api/Użytkownicy/id
        [HttpGet("{id}")]
        public ActionResult<Użytkownicy> GetUżytkownik(int id)
        {
            var użytkownik = _context.Użytkownicy.Find(id);
            if (użytkownik == null)
            {
                return NotFound();
            }
            return użytkownik;
        }

        // POST: api/Użytkownicy
        [HttpPost]
        public ActionResult<Użytkownicy> PostUżytkownik(Użytkownicy użytkownik)
        {
            _context.Użytkownicy.Add(użytkownik);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetUżytkownik), new { id = użytkownik.Id_Użytkownika }, użytkownik);
        }

        // PUT: api/Użytkownicy/id
        [HttpPut("{id}")]
        public IActionResult PutUżytkownik(int id, Użytkownicy użytkownik)
        {
            if (id != użytkownik.Id_Użytkownika)
            {
                return BadRequest();
            }

            _context.Entry(użytkownik).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Użytkownicy.Any(u => u.Id_Użytkownika == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Użytkownicy/id
        [HttpDelete("{id}")]
        public IActionResult DeleteUżytkownik(int id)
        {
            var użytkownik = _context.Użytkownicy.Find(id);
            if (użytkownik == null)
            {
                return NotFound();
            }

            _context.Użytkownicy.Remove(użytkownik);
            _context.SaveChanges();

            return NoContent();
        }

    }
}