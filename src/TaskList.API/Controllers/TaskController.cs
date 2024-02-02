using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskList.Domain.DTOs.Requests;
using TaskList.Domain.Interfaces.Services;

namespace TaskList.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _service;
        private readonly IMapper _mapper;

        public TaskController(ITaskService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Domain.Entities.Task), StatusCodes.Status200OK)]
        [Route("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return Ok(await _service.GetAsync(id));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Domain.Entities.Task>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] CreateTaskRequestDto task)
        {
            return Ok(await _service.InsertAsync(_mapper.Map<Domain.Entities.Task>(task)));
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromBody] UpdateTaskRequestDto task)
        {
            await _service.UpdateAsync(_mapper.Map<Domain.Entities.Task>(task));
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }

        [HttpPatch]
        [Route("{id:int}/start")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Start([FromRoute] int id)
        {
            await _service.Start(id);
            return Ok();
        }

        [HttpPatch]
        [Route("{id:int}/end")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> End([FromRoute] int id)
        {
            await _service.End(id);
            return Ok();
        }
    }
}
