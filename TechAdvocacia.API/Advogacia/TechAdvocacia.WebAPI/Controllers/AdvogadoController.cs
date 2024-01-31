using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechAdvocacia.Core.Models;
using TechAdvocacia.Data;

[ApiController]
[Route("[controller]")]
public class AdvogadoController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AdvogadoController(ApplicationDbContext context)
    {
        _context = context;
    }

    // POST: /Advogado
    [HttpPost]
    public IActionResult CreateAdvogado([FromBody] Advogado advogado)
    {
        _context.Advogados.Add(advogado);
        _context.SaveChanges();
        return Ok(advogado);
    }

    // GET: /Advogado
    [HttpGet]
    public IActionResult GetAdvogados()
    {
        var advogados = _context.Advogados.ToList();
        return Ok(advogados);
    }

    // GET: /Advogado/{id}
    [HttpGet("{id}")]
    public IActionResult GetAdvogado(int id)
    {
        var advogado = _context.Advogados.Find(id);
        if (advogado == null)
        {
            return NotFound();
        }
        return Ok(advogado);
    }

    // PUT: /Advogado/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateAdvogado(int id, [FromBody] Advogado advogado)
    {
        if (id != advogado.Id)
        {
            return BadRequest();
        }

        _context.Entry(advogado).State = EntityState.Modified;

        try
        {
            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Advogados.Any(a => a.Id == id))
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

    // DELETE: /Advogado/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteAdvogado(int id)
    {
        var advogado = _context.Advogados.Find(id);
        if (advogado == null)
        {
            return NotFound();
        }

        _context.Advogados.Remove(advogado);
        _context.SaveChanges();
        return NoContent();
    }
}
