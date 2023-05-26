using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRACTICAL_EXAM_NET.Entities;

namespace PRACTICAL_EXAM_NET.Controllers
{
    public class ExamsController : Controller
    {
        private readonly DataContext _context;

        public ExamsController(DataContext context)
        {
            _context = context;
        }

        // GET: Exams
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.exams.Include(e => e.classes).Include(e => e.facultys).Include(e => e.subjects);
            return View(await dataContext.ToListAsync());
        }

        // GET: Exams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.exams == null)
            {
                return NotFound();
            }

            var exam = await _context.exams
                .Include(e => e.classes)
                .Include(e => e.facultys)
                .Include(e => e.subjects)
                .FirstOrDefaultAsync(m => m.ExamId == id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        // GET: Exams/Create
        public IActionResult Create()
        {
            ViewData["classesId"] = new SelectList(_context.classes, "Id", "Name");
            ViewData["facultysId"] = new SelectList(_context.faculty, "Id", "Name");
            ViewData["subjectsId"] = new SelectList(_context.subject, "Id", "Name");
            return View();
        }

        // POST: Exams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExamId,StartTime,ExamDate,ExamDuration,classesId,facultysId,subjectsId,status")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["classesId"] = new SelectList(_context.classes, "Id", "Name", exam.classesId);
            ViewData["facultysId"] = new SelectList(_context.faculty, "Id", "Name", exam.facultysId);
            ViewData["subjectsId"] = new SelectList(_context.subject, "Id", "Name", exam.subjectsId);
            return View(exam);
        }

        // GET: Exams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.exams == null)
            {
                return NotFound();
            }

            var exam = await _context.exams.FindAsync(id);
            if (exam == null)
            {
                return NotFound();
            }
            ViewData["classesId"] = new SelectList(_context.classes, "Id", "Name", exam.classesId);
            ViewData["facultysId"] = new SelectList(_context.faculty, "Id", "Name", exam.facultysId);
            ViewData["subjectsId"] = new SelectList(_context.subject, "Id", "Name", exam.subjectsId);
            return View(exam);
        }

        // POST: Exams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExamId,StartTime,ExamDate,ExamDuration,classesId,facultysId,subjectsId,status")] Exam exam)
        {
            if (id != exam.ExamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamExists(exam.ExamId))
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
            ViewData["classesId"] = new SelectList(_context.classes, "Id", "Name", exam.classesId);
            ViewData["facultysId"] = new SelectList(_context.faculty, "Id", "Name", exam.facultysId);
            ViewData["subjectsId"] = new SelectList(_context.subject, "Id", "Name", exam.subjectsId);
            return View(exam);
        }

        // GET: Exams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.exams == null)
            {
                return NotFound();
            }

            var exam = await _context.exams
                .Include(e => e.classes)
                .Include(e => e.facultys)
                .Include(e => e.subjects)
                .FirstOrDefaultAsync(m => m.ExamId == id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        // POST: Exams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.exams == null)
            {
                return Problem("Entity set 'DataContext.exams'  is null.");
            }
            var exam = await _context.exams.FindAsync(id);
            if (exam != null)
            {
                _context.exams.Remove(exam);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExamExists(int id)
        {
          return (_context.exams?.Any(e => e.ExamId == id)).GetValueOrDefault();
        }
    }
}
