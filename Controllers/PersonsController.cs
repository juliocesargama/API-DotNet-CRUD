using CRUDAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CRUDAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly Context _context;
        public PersonsController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetAllAsync(){
            return await _context.Persons.ToListAsync();
        }

        [HttpGet("{personID}")]
        public async Task<ActionResult<Person>> GetPersonByIDAsync(int personID){
            Person person = await _context.Persons.FindAsync(personID);
            if(person == null){
                return NotFound();
            }else{
                return person;
            }
        }
        [HttpPost]
        public async Task <ActionResult<Person>> SavePersonAsync(Person person){
            await _context.Persons.AddAsync(person);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePersonAsync(Person person){
            _context.Persons.Update(person);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{personID}")]
        public async Task<ActionResult> DeletePersonAsync(int personID){
            Person person = await _context.Persons.FindAsync(personID);
            _context.Remove(person);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}