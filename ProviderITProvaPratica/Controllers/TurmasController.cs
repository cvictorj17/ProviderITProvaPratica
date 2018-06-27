using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProviderITProvaPratica.Data;
using ProviderITProvaPratica.Models;

namespace ProviderITProvaPratica.Controllers
{
    public class TurmasController : Controller
    {
        private readonly FaculdadeContexto _context;

        public TurmasController(FaculdadeContexto context)
        {
            _context = context;
        }

        // GET: Turmas
        public async Task<IActionResult> Index()
        {
            var faculdadeContexto = _context.Turmas.Include(t => t.Aluno).Include(t => t.Disciplina);
            return View(await faculdadeContexto.ToListAsync());
        }

        // GET: Turmas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turma = await _context.Turmas
                .Include(t => t.Aluno)
                .Include(t => t.Disciplina)
                .SingleOrDefaultAsync(m => m.TurmaID == id);
            if (turma == null)
            {
                return NotFound();
            }

            return View(turma);
        }

        // GET: Turmas/Create
        public IActionResult Create()
        {
            ViewData["AlunoID"] = new SelectList(_context.Alunos, "AlunoID", "AlunoID");
            ViewData["AlunoNome"] = new SelectList(_context.Alunos, "AlunoID", "Nome");
            ViewData["DisciplinaID"] = new SelectList(_context.Disciplinas, "DisciplinaID", "DisciplinaID");
            ViewData["DisciplinaNome"] = new SelectList(_context.Disciplinas, "DisciplinaID", "NomeDisciplina");
            return View();
        }

        // POST: Turmas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TurmaID,CodigoTurma,Curso,Periodo,DisciplinaID,AlunoID,DataCriacao")] Turma turma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(turma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlunoID"] = new SelectList(_context.Alunos, "AlunoID", "AlunoID", turma.AlunoID);
            ViewData["AlunoNome"] = new SelectList(_context.Alunos, "AlunoID", "Nome", turma.AlunoID);
            ViewData["DisciplinaID"] = new SelectList(_context.Disciplinas, "DisciplinaID", "DisciplinaID", turma.DisciplinaID);
            ViewData["DisciplinaNome"] = new SelectList(_context.Disciplinas, "DisciplinaID", "NomeDisciplina", turma.DisciplinaID);
            return View(turma);
        }

        // GET: Turmas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turma = await _context.Turmas.SingleOrDefaultAsync(m => m.TurmaID == id);
            if (turma == null)
            {
                return NotFound();
            }
            ViewData["AlunoID"] = new SelectList(_context.Alunos, "AlunoID", "AlunoID", turma.AlunoID);
            ViewData["AlunoNome"] = new SelectList(_context.Alunos, "AlunoID", "Nome", turma.AlunoID);
            ViewData["DisciplinaID"] = new SelectList(_context.Disciplinas, "DisciplinaID", "DisciplinaID", turma.DisciplinaID);
            ViewData["DisciplinaNome"] = new SelectList(_context.Disciplinas, "DisciplinaID", "NomeDisciplina", turma.DisciplinaID);

            return View(turma);
        }

        // POST: Turmas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TurmaID,CodigoTurma,Curso,Periodo,DisciplinaID,AlunoID,DataCriacao")] Turma turma)
        {
            if (id != turma.TurmaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(turma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TurmaExists(turma.TurmaID))
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
            ViewData["AlunoID"] = new SelectList(_context.Alunos, "AlunoID", "AlunoID", turma.AlunoID);
            ViewData["AlunoNome"] = new SelectList(_context.Alunos, "AlunoID", "Nome", turma.AlunoID);
            ViewData["DisciplinaID"] = new SelectList(_context.Disciplinas, "DisciplinaID", "DisciplinaID", turma.DisciplinaID);
            ViewData["DisciplinaNome"] = new SelectList(_context.Disciplinas, "DisciplinaID", "NomeDisciplina", turma.DisciplinaID);

            return View(turma);
        }

        // GET: Turmas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turma = await _context.Turmas
                .Include(t => t.Aluno)
                .Include(t => t.Disciplina)
                .SingleOrDefaultAsync(m => m.TurmaID == id);
            if (turma == null)
            {
                return NotFound();
            }

            return View(turma);
        }

        // POST: Turmas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var turma = await _context.Turmas.SingleOrDefaultAsync(m => m.TurmaID == id);
            _context.Turmas.Remove(turma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TurmaExists(int id)
        {
            return _context.Turmas.Any(e => e.TurmaID == id);
        }
    }
}
