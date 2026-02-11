using PapaNouel.Models;
using PapaNouel.Simulation;
using Microsoft.AspNetCore.Mvc;
using PapaNouel_API.DTOs;
using PapaNouel_API.Mapper;

namespace PapaNouel_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<IJouet>> Get()
        {
            Simulation sim = new Simulation();
            List<IJouet> list = sim.GetJouets();
            List<JouetDTO> listDTO = new List<JouetDTO>();

            foreach (IJouet jouet in list)
            {
                listDTO.Add(jouet.ToDto());
            }
            return Ok(listDTO);  
        }
    }
}
