using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class StockItemsController : ControllerBase
    {
        private readonly DataContext _context;
        public StockItemsController(DataContext context)
        {
            _context = context;
        }
        // GET api/StockItems
        [HttpGet]
        public async Task<IActionResult> GetStockItems()
        {
            var values = await _context.StockItems.Take(1000).ToListAsync();
            return Ok(values);
        }

        // GET api/StockItems/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult>  GetStockItem(int id)
        {
            var value =  await _context.StockItems.FirstOrDefaultAsync(x => x.StockID == id);
            return Ok(value);
        }

        // POST api/PostStockItem
        [HttpPost]
        public async Task<ActionResult<StockItem>> PostStockItem([FromBody] StockItem stockItem)  
        {
            _context.StockItems.Add(stockItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStockItem), new { id = stockItem.StockID }, stockItem);            
        }

        // PUT api/StockItem/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStockItem(long id, StockItem item)
{
        if (id != item.StockID)
        {
            return BadRequest();
        }

        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
}
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}