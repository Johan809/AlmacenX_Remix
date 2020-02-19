using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlmacenX_Remix.Models;

namespace AlmacenX_Remix.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductoContext _context;

        public ProductoController(ProductoContext context)
        {
            _context = context;
        }

        // GET: Producto
        public async Task<IActionResult> Index()
        {
            return View(await _context.Productos.ToListAsync());
        }

        // GET: Producto/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Producto());
            else
                return View(_context.Productos.Find(id));

        }

        // POST: Producto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("ProductID,NombreProduct,Descripcion,stock,PrecioProd")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                if (producto.ProductID == 0)
                    _context.Add(producto);
                else
                    _context.Update(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Producto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var prod = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(prod);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
