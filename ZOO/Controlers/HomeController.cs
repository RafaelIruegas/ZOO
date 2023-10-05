using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZOO.Models;
using ZOO.Models.ViewModels;

namespace ZOO.Controlers
{
	public class HomeController : Controller
	{
		public IActionResult Index (IndexVM vm) 
		{
            AnimalesContext context = new AnimalesContext();
            List<Ani> datos = context.Clase.Select(Clase => new Ani
            {
                Id = Clase.Id,
                Nombre = Clase.Nombre ?? " ",
                Descripcion = Clase.Descripcion ?? " "

            }).ToList();
            vm.Ani2 = datos;
            return View(vm);
        }
		public IActionResult Especies(string Id, EspeciesVM vm)
		{
			AnimalesContext contex = new AnimalesContext();
			var datos = contex.Especies.Where(x => x.IdClaseNavigation.Nombre == Id).Select(Especies1 => new SP
            {
				nombre = Especies1.Especie,
				id = Especies1.Id


			}).ToList();
			int Claseid = contex.Clase.Where(x => x.Nombre == Id).Select(x  => x.Id).First();
			vm.nombre = Id;
			vm.id = Claseid;
			vm.ListaAni = datos;
			return View(vm);	
		}
		public IActionResult Especie(string Id, Especie vm)
		{
			AnimalesContext context = new AnimalesContext();
			var animal = context.Especies.Include(x => x.IdClaseNavigation).Where(x => x.Especie == Id).Select(x => new Esp
			{ id = x.Id,especie = x.IdClaseNavigation.Nombre, habitad = x.Habitat ?? " ", descripcion = x.Observaciones ?? " ", peso = x.Peso, tamaño = x.Tamaño, nombre = x.IdClaseNavigation.Nombre }).First();
			return View(animal);	
		}
	}
}
