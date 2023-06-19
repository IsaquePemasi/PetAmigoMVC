using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetAmigoMVC.Data;
using PetAmigoMVC.Models;

namespace PetAmigoMVC.Controllers;

[Authorize]
public class DoacaosController : Controller
{
    private readonly PetAmigoContext _context;

    public DoacaosController(PetAmigoContext context)
    {
        _context = context;
    }
    // GET: Doacaos
    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        return _context.Doacaos != null ?
                    View(await _context.Doacaos.ToListAsync()) :
                    Problem("Entity set 'PetAmigoContext.Doacaos'  is null.");
    }

    // GET: Doacaos/Details/5
    [AllowAnonymous]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.Doacaos == null)
        {
            return NotFound();
        }

        var doacao = await _context.Doacaos
            .FirstOrDefaultAsync(m => m.Id == id);
        if (doacao == null)
        {
            return NotFound();
        }

        return View(doacao);
    }

    // GET: Doacaos/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Doacaos/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Nome,Raca,Usuario,Tipo,Imgurl,Cidade,Estado,Cep,Descricao")] Doacao doacao)
    {
        if (ModelState.IsValid)
        {
            _context.Add(doacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(doacao);
    }

    // GET: Doacaos/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.Doacaos == null)
        {
            return NotFound();
        }

        var doacao = await _context.Doacaos.FindAsync(id);
        if (doacao == null)
        {
            return NotFound();
        }
        return View(doacao);
    }

    // POST: Doacaos/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Raca,Usuario,Tipo,Imgurl,Cidade,Estado,Cep,Descricao")] Doacao doacao)
    {
        if (id != doacao.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(doacao);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoacaoExists(doacao.Id))
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
        return View(doacao);
    }

    // GET: Doacaos/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.Doacaos == null)
        {
            return NotFound();
        }

        var doacao = await _context.Doacaos
            .FirstOrDefaultAsync(m => m.Id == id);
        if (doacao == null)
        {
            return NotFound();
        }

        return View(doacao);
    }

    // POST: Doacaos/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.Doacaos == null)
        {
            return Problem("Entity set 'PetAmigoContext.Doacaos'  is null.");
        }
        var doacao = await _context.Doacaos.FindAsync(id);
        if (doacao != null)
        {
            _context.Doacaos.Remove(doacao);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool DoacaoExists(int id)
    {
        return (_context.Doacaos?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}