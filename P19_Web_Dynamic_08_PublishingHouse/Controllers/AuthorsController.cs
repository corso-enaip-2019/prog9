﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using P19_Web_Dynamic_08_PublishingHouse.ViewModels;

namespace P19_Web_Dynamic_08_PublishingHouse.Controllers
{
    public class AuthorsController : Controller
    {
        private AppDbContext _context;
        
        public AuthorsController(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var viewModels = await _context.Authors
                .Include(model => model.BookAuthors)
                .Select(model => new AuthorRowViewModel
                    {
                        Id = model.Id,
                        Name = model.Name,
                        BookCount = model.BookAuthors.Count
                    })
                .ToListAsync();

            return View(viewModels);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await _context.Authors
                .Include(x => x.BookAuthors)
                .Select(model => new AuthorEditViewModel
                {
                    Id = model.Id,
                    Name = model.Name,
                    BooksIds = model.BookAuthors.Select(ba => ba.BookId).ToList(),
                })
                .FirstOrDefaultAsync(x => x.Id == id);

            if (viewModel == null)
            {
                return NotFound();
            }
            else
            {
                var books = await _context.Books
                    .Select(b => new SelectListItem {
                        Text = b.Title,
                        Value = b.Id.ToString(),
                    })
                    .ToListAsync();

                ViewData["books"] = books;

                return View(viewModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AuthorEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var model = await _context.Authors
                .Include(x => x.BookAuthors)
                .FirstOrDefaultAsync(x => x.Id == viewModel.Id);

            if (model != null)
            {
                model.Name = viewModel.Name;
                model.BookAuthors.Clear();
                model.BookAuthors.AddRange(viewModel.BooksIds
                    .Select(bookId => new BookAuthor { BookId = bookId, AuthorId = viewModel.Id }));
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var viewModel = await _context.Authors
                .Select(model => new AuthorDeleteViewModel
                    {
                        Id = model.Id,
                        Name = model.Name,
                    })
                .FirstOrDefaultAsync(x => x.Id == id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(AuthorDeleteViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var model = await _context.Authors
                .Include(m => m.BookAuthors)
                .FirstOrDefaultAsync(x => x.Id == viewModel.Id);

            if (model == null)
            {
                return NotFound();
            }

            _context.Authors.Remove(model);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Insert()
        {
            var viewModel = new AuthorInsertViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(AuthorInsertViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var model = new Author
            {
                Name = viewModel.Name
            };
            
            _context.Authors.Add(model);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
