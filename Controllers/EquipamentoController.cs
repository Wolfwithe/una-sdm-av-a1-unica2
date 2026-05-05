using Microsoft.AspNetCore.Mvc;
using ValeAtivos324123267.Data;
using ValeAtivos324123267.Models;

namespace ValeAtivos324123267.Controllers
{
   [ApiController]
[Route("api/[controller]")]
public class EquipamentoController : ControllerBase
{
    private readonly AppDbContext _context;

    public EquipamentoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Post(Equipamento equipamento)
    {
        _context.Equipamentos.Add(equipamento);
        _context.SaveChanges();

        return Ok(equipamento);
    }

    [HttpGet]
    public IActionResult Get()
    {
        var lista = _context.Equipamentos.ToList();
        return Ok(lista);
    }
}
}