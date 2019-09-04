using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sistema.Models;

namespace sistema.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly sistemaContext _context;

        public CategoriasController(sistemaContext context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index(string sortOrder, 
                                               string currentFilter, string searchString,
                                                int? page) //paramtros de entrada al index paramtero page es el numero de pagina

            //aqui en el index de este controlador realizamos el metodo ViewData, donde realiza la solicitud
            //la vista al controlador y el controlador lñe envia los datos, ojo solo del controlador a la vista
            //sortOrder es el parametro que recibe el controlador
        {
            ViewData["NombreSortParm"] = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : ""; // validamos si es nulo o si existe
            ViewData["DescripcionSortParm"] = sortOrder == "descripcion_asc" ? "descripcion_desc" : "descripcion_asc";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString; // proporciona vista cpon la cedena alctual, mantiene l,a configuracion del filtro con la informacion
            ViewData["CurrentSort"] = sortOrder; // mantener el orden de clasificacion durante la paginacion
            var categorias = from s in _context.Categoria select s; // aqui es parea obtener el litaqdo de todas las categorias en una variable llamda categoria

            if (!String.IsNullOrEmpty(searchString)) // aca le coloco lo que esta recibiendo de busqueda y lo asocie a lo que tengo 
            {
                categorias = categorias.Where(s=>s.Nombre.Contains(searchString)|| s.Descripcion.Contains(searchString));

            }


            switch (sortOrder)
            {
                case "nombre_desc":
                    categorias = categorias.OrderByDescending(s => s.Nombre);
                    break;
                case "descripcion_desc":
                    categorias = categorias.OrderByDescending(s => s.Descripcion);
                    break;
                case "descripcion_asc":
                    categorias = categorias.OrderBy(s => s.Descripcion);
                    break;

                default:
                    categorias = categorias.OrderBy(s => s.Nombre);
                    break;
           }

            //return View(await categorias.AsNoTracking().ToListAsync());
            //Se recomienda el uso de NoTracking() cuando su consulta está destinada a operaciones de lectura.
            //    En estos escenarios, recuperar sus entidades, pero su contexto no las rastrea. Esto garantiza
            //    un uso mínimo de la memoria y un rendimiento óptimo  y la palabra await se usa cuando se invoca
            //    a un metodo asincronico, que esa palabra le indica al método que invoca al ToListAsync() que tiene
            //    que esperar al metodo ToListAsync() que finalice su tarea y luego proseguir con lo demás y el
            //    ToListAsync() es un método asincronico
            // return View(await _context.Categoria.ToListAsync()); este es el que ya tenia estblaecido
            int pageSize = 3;
            return View(await Paginacion<Categoria>.CreateAsync(categorias.AsNoTracking(), page ?? 1, pageSize));
            //metodo createAsync lo que hace es devolver todas las categorias a la vista respectiva,
            //    pero las va volver liostada segun nuestra varaible pageSize,  que son las ??, siginifica que nos
            //    va a devolver el valor de page, y si no tiene devuelve 1 si es null
        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria
                .FirstOrDefaultAsync(m => m.CategoriaID == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // GET: Categorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoriaID,Nombre,Descripcion,Estado")] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }

        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        // POST: Categorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoriaID,Nombre,Descripcion,Estado")] Categoria categoria)
        {
            if (id != categoria.CategoriaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaExists(categoria.CategoriaID))
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
            return View(categoria);
        }

        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria
                .FirstOrDefaultAsync(m => m.CategoriaID == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoria = await _context.Categoria.FindAsync(id);
            _context.Categoria.Remove(categoria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categoria.Any(e => e.CategoriaID == id);
        }
    }
}
