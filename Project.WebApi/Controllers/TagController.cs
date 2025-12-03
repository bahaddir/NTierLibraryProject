using Microsoft.AspNetCore.Mvc;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagManager _tagManager;

        public TagController(ITagManager tagManager)
        {
            _tagManager = tagManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tags = await _tagManager.GetAllAsync();
            return Ok(tags);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tag = await _tagManager.GetByIdAsync(id);
            if (tag == null) return NotFound();
            return Ok(tag);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TagDto dto)
        {
            var createdTag = await _tagManager.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdTag.ID }, createdTag);
        }

        [HttpPut]
        public async Task<IActionResult> Update(TagDto dto)
        {
            var updatedTag = await _tagManager.UpdateAsync(dto);
            return Ok(updatedTag);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _tagManager.DeleteAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}