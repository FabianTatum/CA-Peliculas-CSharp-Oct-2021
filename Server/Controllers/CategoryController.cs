using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CrAgPeliculas.App.Shared.Entity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CrAgPeliculas.App.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly AppContext context;

        public CategoryController(AppContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Category category)
        {
            context.Add(category); 
            await context.SaveChangesAsync();
            return category.Id;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return await context.CategoryTB.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id)
        {
            return await context.CategoryTB.FirstOrDefaultAsync(c => c.Id == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Category category)
        {
            context.Attach(category).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}