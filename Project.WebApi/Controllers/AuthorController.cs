using Microsoft.AspNetCore.Mvc;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorManager _authorManager;

        public AuthorController(IAuthorManager authorManager)
        {
            _authorManager = authorManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var authors = await _authorManager.GetAllAsync();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var author = await _authorManager.GetByIdAsync(id);
            if (author == null) return NotFound();
            return Ok(author);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorDto dto)
        {
            var createdAuthor = await _authorManager.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdAuthor.ID }, createdAuthor);
        }

        [HttpPut]
        public async Task<IActionResult> Update(AuthorDto dto)
        {
            var updatedAuthor = await _authorManager.UpdateAsync(dto);
            return Ok(updatedAuthor);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _authorManager.DeleteAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}