using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using P19_Web_Dynamic_08_PublishingHouse.ViewModels;

namespace P19_Web_Dynamic_08_PublishingHouse.Controllers
{
    public class BooksController : Controller
    {
        private AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var viewModels = await _context.Books
                .Include(model => model.BookAuthors)
                .ThenInclude(model => model.Author)
                .Select(model => new BookRowViewModel
                {
                    Id = model.Id,
                    Title = model.Title,
                    Authors = string.Join(", ", model.BookAuthors.Select(ba => ba.Author.Name))
                })
                .ToListAsync();

            return View(viewModels);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await _context.Books
                .Include(x => x.BookAuthors)
                .Select(model => new BookEditViewModel
                {
                    Id = model.Id,
                    Title = model.Title,
                    AuthorsIds = model.BookAuthors.Select(ba => ba.AuthorId).ToList(),
                })
                .FirstOrDefaultAsync(x => x.Id == id);

            if (viewModel == null)
            {
                return NotFound();
            }
            else
            {
                var authors = await _context.Authors
                    .Select(b => new SelectListItem
                    {
                        Text = b.Name,
                        Value = b.Id.ToString(),
                    })
                    .ToListAsync();

                ViewData["authors"] = authors;

                return View(viewModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BookEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var model = await _context.Books
                .Include(x => x.BookAuthors)
                .FirstOrDefaultAsync(x => x.Id == viewModel.Id);

            if (model != null)
            {
                model.Title = viewModel.Title;
                model.BookAuthors.Clear();
                model.BookAuthors.AddRange(viewModel.AuthorsIds
                    .Select(authorId => new BookAuthor { AuthorId = authorId, BookId = viewModel.Id }));
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
            var viewModel = await _context.Books
                .Select(model => new BookDeleteViewModel
                {
                    Id = model.Id,
                    Title = model.Title,
                })
                .FirstOrDefaultAsync(x => x.Id == id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(BookDeleteViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var model = await _context.Books
                .Include(m => m.BookAuthors)
                .FirstOrDefaultAsync(x => x.Id == viewModel.Id);

            if (model == null)
            {
                return NotFound();
            }

            _context.Books.Remove(model);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Insert()
        {
            var viewModel = new BookInsertViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(BookInsertViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var model = new Book
            {
                Title = viewModel.Title
            };

            _context.Books.Add(model);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}