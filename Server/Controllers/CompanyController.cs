
using System.Threading.Tasks;
using Blazor.Learner.Server.Data;
using Blazor.Learner.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Learner.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CompanyController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var devs = await _context.Companies.ToListAsync();
            return Ok(devs);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var dev = await _context.Companies.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(dev);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Company company)
        {
            _context.Add(company);
            await _context.SaveChangesAsync();
            return Ok(company.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Company company)
        {
            _context.Entry(company).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dev = new Company { Id = id };
            _context.Remove(dev);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
