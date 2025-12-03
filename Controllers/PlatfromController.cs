using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dtos;

namespace PlatformService.Controllers
{
    
    [Route("Api/[controller]")] 
    [ApiController]
    public class PlatfromController : ControllerBase
    {
        private readonly IPlatformRepo _platformRepo;
         private readonly IMapper _mapper;
        public PlatfromController(IPlatformRepo platformRepo,IMapper mapper)
        {
            _platformRepo=platformRepo;
            _mapper=mapper;
        }

      


        [HttpGet()]
        public ActionResult<IEnumerable<PLatformReadDto>> GetPlatforms()
        {
           var platfroms= _platformRepo.getAllPlatforms();
            return Ok(_mapper.Map<IEnumerable<PLatformReadDto>>(platfroms));
        }




    }




}