using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Controllers
{
     [Route("api/product")]
     [ApiController]
     public class ProductController : ControllerBase
     {
          private readonly DatabaseContext _context;

          public ProductController(DatabaseContext context)
          {
               _context = context;

               if (_context.Product.Count() == 0)
               {
                    // Create a new TodoItem if collection is empty,
                    // which means you can't delete all TodoItems.
                    _context.Product.Add(new Product {P_id=1, P_Name = "Saffran Gold", Description="5g prima kvalitet", InStock=true, NutritionFacts="Blablablabla", Price=100 });
                    _context.Product.Add(new Product { P_id = 2, P_Name = "Saffran Silver", Description = "5g prima kvalitet", InStock = true, NutritionFacts = "Blablablabla", Price = 100 });
                    _context.SaveChanges();
               }
          }

          [HttpGet]
          public async Task<ActionResult<IEnumerable<Product>>> GetTodoItems()
          {
               return await _context.Product.ToListAsync();
          }

          [HttpGet("{id}")]
          public async Task<ActionResult<Product>> GetTodoItem(int id)
          {
               var todoItem = await _context.Product.FindAsync(id);

               if (todoItem == null)
               {
                    return NotFound();
               }

               return todoItem;
          }

          [HttpPost]
          public async Task<ActionResult<Product>> PostTodoItem(Product prod)
          {
               _context.Product.Add(prod);
               await _context.SaveChangesAsync();

               return CreatedAtAction("GetTodoItem", new { id = prod.P_id }, prod);
          }
     }
}