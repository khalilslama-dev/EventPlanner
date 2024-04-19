using AutoMapper;
using EventPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {

        private readonly IMapper _mapper;
        public EventController(IMapper mapper)
        {
            _mapper = mapper;
        }


        public static Collection<Event> _events { get; set; } = new Collection<Event> { new Event { Id = 1, Name = "Khalil's event", Description = "This is Khalil's event"} };
        // GET: api/<EventController>
        [HttpGet]
        public ActionResult<IEnumerable<Event>> Get()
        {
            return Ok(_events);
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public ActionResult<Event> Get(int id)
        {
            Event Event = _events.SingleOrDefault(Event => Event.Id == id);
            if (Event == null)
            {
                return NotFound();
            }
            return Ok(Event);   
        }

        // POST api/<EventController>
        [HttpPost]
        public ActionResult Post([FromBody] EventDto EventDto)
        {
            Event evet = _mapper.Map<Event>(EventDto);
            _events.Add(evet);
            return Ok();
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] EventDto NewEvent)
        {
            Event OldEvent = _events.SingleOrDefault(Event => Event.Id == id);
            if (OldEvent == null)
            {
                return NotFound();
            }
            OldEvent.Name = NewEvent.Name;
            OldEvent.Description = NewEvent.Description;
            return Ok(OldEvent);
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Event OldEvent = _events.SingleOrDefault(Event => Event.Id == id);
            if (OldEvent == null)
            {
                return NotFound();
            }
            _events.Remove(OldEvent);
            return Ok();
        }
    }
}
