using Microsoft.AspNetCore.Mvc;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookManager _bookManager;

        public BookController(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await _bookManager.GetAllAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _bookManager.GetByIdAsync(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookDto dto)
        {
            var createdBook = await _bookManager.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdBook.ID }, createdBook);
        }

        [HttpPut]
        public async Task<IActionResult> Update(BookDto dto)
        {
            var updatedBook = await _bookManager.UpdateAsync(dto);
            return Ok(updatedBook);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _bookManager.DeleteAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}