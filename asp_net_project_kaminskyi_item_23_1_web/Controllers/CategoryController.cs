using asp_net_kaminskyi_persistance;
using asp_net_project_kaminskyi_item_23_1_web.Domain;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp_net_project_kaminskyi_item_23_1_web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ShopDatabaseContext dbContext;

        public CategoryController(ShopDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("list")]
        public async Task<IActionResult> Get()
        {
            var categories = await dbContext.Categories.ToListAsync();
            return Ok(categories);
        }


        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await dbContext.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpGet("byTitle")]
        public async Task<IActionResult> GetByTitle(string title)
        {
            var category = await dbContext.Categories.FirstOrDefaultAsync(c => c.Title == title);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }



        [HttpPost]
        public async Task<IActionResult> Post(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return Ok(category);
        }


        [HttpPut]
        public async Task<IActionResult> Put(Category category)
        {
            var dbCategory = await dbContext.Categories.FindAsync(category.Id);
            if (dbCategory == null)
            {
                return NotFound();
            }

            dbCategory.Title = category.Title;

            await dbContext.SaveChangesAsync();

            return Ok(category);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await dbContext.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            dbContext.Remove(category);

            await dbContext.SaveChangesAsync();

            return NoContent();
        }


    }
}
