using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiproWebAPI.Models;

namespace WiproWebAPI.Controllers
{
    public class MoedaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		[Route("api/AddItemFila")]
		public ReturnAllServices AddItemFila([FromBody] Moeda dados)
		{
			ReturnAllServices retorno = new ReturnAllServices();
			try
			{
				dados.AddItemFila();
				retorno.Result = true;
				retorno.ErrorMessage = string.Empty;
			}
			catch (Exception ex)
			{
				retorno.Result = false;
				retorno.ErrorMessage = "Erro ao tentar inserir a Moeda: " + ex.Message;
			}
			return retorno;
		}

		[HttpGet]
		[Route("api/GetItemFila")]
		public Moeda GetItemFila()
		{
			return new Moeda().GetItemFila();
		}
	}
}
