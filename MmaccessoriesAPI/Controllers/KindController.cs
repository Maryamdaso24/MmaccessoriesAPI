using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MmaccessoriesAPI.Models;
namespace MmaccessoriesAPI.Controllers
{


        [Route("api/[controller]")]
        [ApiController]
        public class KindController : ControllerBase
        {
            private readonly ShopContext _context;
            public KindController(ShopContext context)
            {
                _context = context;
                _context.Database.EnsureCreated();
            }

            [HttpGet]
            public ActionResult GetAllProducts()
            {
                return Ok(_context.Kinds.ToArray());
            }

            [HttpGet("{id}")]
            public ActionResult GetProduct(int id)
            {
                var Kinds = _context.Kinds.Find(id);
                if (Kinds == null)
                {
                    return NotFound();
                }
                return Ok(Kinds);
            }
            [HttpPost]
            public async Task<ActionResult<Kinds>> PostProduct(Kinds Kinds)
            {
                _context.Kinds.Add(Kinds);
                await _context.SaveChangesAsync();

                return CreatedAtAction(
                    "GetProduct",
                    new { id = Kinds.Id },
                    Kinds);
            }
            [HttpPut("{id}")]
            public async Task<ActionResult> PutProduct(int id, Kinds Kinds)
            {
                if (id != Kinds.Id)
                {
                    return BadRequest();
                }

                _context.Entry(Kinds).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Kinds.Any(p => p.Id == id))
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
            [HttpDelete("{id}")]
            public async Task<ActionResult<Kinds>> DeleteProduct(int id)
            {
                var Kinds = await _context.Kinds.FindAsync(id);
                if (Kinds == null)
                {
                    return NotFound();
                }

                _context.Kinds.Remove(Kinds);
                await _context.SaveChangesAsync();

                return Kinds;
            }
        }
    }
