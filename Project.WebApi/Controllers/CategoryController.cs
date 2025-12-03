using Microsoft.AspNetCore.Mvc;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryManager.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryManager.GetByIdAsync(id);
            if (category == null) return NotFound();
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto dto)
        {
            var createdCategory = await _categoryManager.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdCategory.ID }, createdCategory);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CategoryDto dto)
        {
            var updatedCategory = await _categoryManager.UpdateAsync(dto);
            return Ok(updatedCategory);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _categoryManager.DeleteAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}