using API_Intro_HomeTask.Data;
using API_Intro_HomeTask.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Intro_HomeTask.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Categpries.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var data = await _context.Categpries.FindAsync(id);
            if (data == null)  return NotFound();

            return Ok(data);        
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest();
            var data = await _context.Categpries.FindAsync(id);
            if (data == null) return NotFound();

            _context.Remove(data);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Category category)
        {
            if(!ModelState.IsValid) return BadRequest();

            await _context.Categpries.AddAsync(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Create", category);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromBody] int id, Category category)
        {
            if (!ModelState.IsValid) return BadRequest();
            var data = await _context.Categpries.FindAsync(id);
            if (data == null) return NotFound();
            data.Name = category.Name;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Search([FromQuery] string search)
        {
            return Ok(search == null ? await _context.Categpries.ToListAsync() :  await _context.Categpries.Where(m => m.Name.Contains(search)).ToListAsync());
        }
    }
}
