using Microsoft.AspNetCore.Mvc;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTagController : ControllerBase
    {
        private readonly IBookTagManager _bookTagManager;

        public BookTagController(IBookTagManager bookTagManager)
        {
            _bookTagManager = bookTagManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bookTags = await _bookTagManager.GetAllAsync();
            return Ok(bookTags);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookTagDto dto)
        {
            var createdBookTag = await _bookTagManager.AddAsync(dto);
            return Ok(createdBookTag);
        }
    }
}