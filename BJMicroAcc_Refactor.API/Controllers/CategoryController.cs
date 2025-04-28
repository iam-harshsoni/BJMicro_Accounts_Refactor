using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.Application.Services.Interfaces;
using BJMicro_Accounts_Refactor.Core.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BJMicroAcc_Refactor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController(ICategoryService categoryService) : ControllerBase
    {
        private readonly ICategoryService _categoryService = categoryService;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var category = await _categoryService.GetAllAsync(pageNumber, pageSize);
                return Ok(category);
            }
            catch (Exception ex)
            {
                // Log exception
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving categories");
            }

        }

        [HttpGet("id/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(long id)
        {
            try
            {
                var category = await _categoryService.GetByIdAsync(id);
                return Ok(category);
            }
            catch (Exception ex)
            {
                // Log exception
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving categories");
            }

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] CreateCategoryDto category)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (category == null)
                    return BadRequest("Category data is null");

                var createdCategoryId = _categoryService.AddAsync(category);

                return CreatedAtAction(nameof(GetById), new { id = createdCategoryId.Id }, null);

            }
            catch (Exception ex)
            {
                // Log exception
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating category");
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryDto category)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (category == null)
                    return BadRequest("Category data is null");

                var exists = await _categoryService.GetByIdAsync(category.CId);

                if (exists == null)
                    return NotFound($"Category with ID {category.CId} not found");

                await _categoryService.UpdateAsync(category);
                return NoContent();
            }
            catch (Exception ex)
            {
                // Log exception
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating category");
            }


        }

        [HttpDelete("id/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                var exists = await _categoryService.GetByIdAsync(id);

                if (exists == null)
                    return NotFound($"Category with ID {id} not found");

                await _categoryService.DeleteAsync(id);
                return Ok(new { success = true, message = "Category deleted successfully" });
            }
            catch (Exception ex)
            {
                // Log exception
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting category");
            }
        }
    }
}