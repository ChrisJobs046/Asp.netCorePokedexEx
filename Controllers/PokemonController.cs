using System;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreExp.Data;
using AspNetCoreExp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreExp.Controllers
{
    public class PokemonController: Controller
    {
        private readonly ApplicationDbContext context;

        public PokemonController(ApplicationDbContext _context){

            context = _context;
        }

        public async Task<IActionResult> Index(){


            var Pokemon = await context.Pokemones.ToListAsync();

            return View(Pokemon);
        }

        [HttpGet]
        public IActionResult Crear(){

            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Crear(Pokemon pokemon){

            if(ModelState.IsValid){

                try{

                    context.Add(pokemon);
                    await context.SaveChangesAsync();

                    return RedirectToAction("Index");

                }
                catch(Exception e){

                    Console.WriteLine(e.Message);
                }

                
            }

            return View(pokemon);
        }

        public IActionResult Actualizar(){

            return View();
        }

        public IActionResult Eliminar(){

            return View();
        }

    }
}