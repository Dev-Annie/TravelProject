using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelProject.Data;
using TravelProject.Models;


namespace TravelProject.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly Context _context;


        public ActivitiesController(Context context)
        {
            _context = context;
            
        }

        // GET: Activities

        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
           
          
            

            var activities = from s in _context.Activities
                           select s;
            switch (sortOrder)
            {
                case "title_desc":
                    activities = activities.OrderByDescending(s => s.Title);
                    break;

               
                default:
                    activities = activities.OrderBy(s => s.Title);
                    break;
            }
            return View(await activities.AsNoTracking().ToListAsync());
        }














        //public async Task<IActionResult> Index()
        //{


        //    return _context.Activities != null ?
        //                View(await _context.Activities.ToListAsync()) :
        //                Problem("Entity set 'Context.Activities' is null.");
        //}

        // GET: Activities/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null || _context.Activities == null)
            {
                return NotFound();
            }

            var activities = await _context.Activities
                .FirstOrDefaultAsync(m => m.IdActivity == id);
            if (activities == null)
            {
                return NotFound();
            }

            return View(activities);
        }

        // GET: Activities/Create
        public IActionResult Create()
        {
            return View();
        }
    

        // POST: Activities/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdActivity,Title,Duration,Type,Price")] Activities activities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(activities);
        }

        // GET: Activities/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Activities == null)
            {
                return NotFound();
            }

            var activities = await _context.Activities.FindAsync(id);
            if (activities == null)
            {
                return NotFound();
            }
            return View(activities);
        }

        // POST: Activities/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdActivity,Title,Duration,Type,Price")] Activities activities)
        {
            if (id != activities.IdActivity)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivitiesExists(activities.IdActivity))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(activities);
        }


        // GET: Activities/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Activities == null)
            {
                return NotFound();
            }

            var activities = await _context.Activities
                .FirstOrDefaultAsync(m => m.IdActivity == id);
            if (activities == null)
            {
                return NotFound();
            }

            return View(activities);
        }

        // POST: Activities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Activities == null)
            {
                return Problem("Entity set 'Context.Activities'  is null.");
            }
            var activities = await _context.Activities.FindAsync(id);
            if (activities != null)
            {
                _context.Activities.Remove(activities);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public bool ActivitiesExists(int id)
        {
            return (_context.Activities?.Any(e => e.IdActivity == id)).GetValueOrDefault();
        }
    }
}



