﻿using BloggingProject.web.Models.Domain;
using BloggingProject.web.Models.ViewModels;
using BloggingProject.web.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BloggingProject.web.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminTagsController : Controller 
    {
        private readonly ITagRepository _tagRepository;
        public AdminTagsController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public async Task<IActionResult> Add(AddTagRequest addTagRequest)
        {
            ValidateAddTagRequest(addTagRequest);
            if(!ModelState.IsValid)
            {
                return View();
            }
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName,
            };

            await _tagRepository.AddAsync(tag);
            return RedirectToAction("List");
        }

        [HttpGet]
        [ActionName("List")]
        public async Task<IActionResult> List()
        {
            //use the repository to access the database
            var tags = await _tagRepository.GetAllAsync();

            return View(tags);
        }

        [HttpGet]
        [ActionName("Edit")]
        public async Task<IActionResult> Edit(Guid id)
        {
            //var tag = _blogDbContext.Tags.Find(id);
            var tag = await _tagRepository.GetAsync(id);
            if (tag != null)
            {
                var editTagRequest = new EditTagRequest
                {
                    Id = tag.Id,
                    Name = tag.Name,
                    DisplayName = tag.DisplayName
                };
                return View(editTagRequest);
            }

            return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditTagRequest editTagRequest)
        {
            var tag = new Tag
            {
                Id = editTagRequest.Id,
                Name = editTagRequest.Name,
                DisplayName = editTagRequest.DisplayName
            };

            var updatedTag = await _tagRepository.UpdateAsync(tag);

            if (updatedTag != null)
            {
                //Show success notification
            }
            else
            {
                //Show error notification
            }

            return RedirectToAction("Edit", new { id = editTagRequest.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(EditTagRequest editTagRequest)
        {
            var deletedTag = await _tagRepository.DeleteAsync(editTagRequest.Id);

            if (deletedTag != null)
            {
                //show success notification
                return RedirectToAction("List");
            }
            //show an error notification
            return RedirectToAction("Edit", new { id = editTagRequest.Id });
        }


        private void ValidateAddTagRequest(AddTagRequest addTagRequest)
        {
            if (addTagRequest.Name is not null && addTagRequest.DisplayName is not null)
            {
                if (addTagRequest.Name == addTagRequest.DisplayName)
                {
                    ModelState.AddModelError("DisplayName", "DisplayName cannot be the same of Name ");
                }
            }
        }
    }
}
