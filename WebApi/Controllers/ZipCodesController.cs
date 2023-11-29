using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Core.Contracts;

namespace Tischreservierung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZipCodesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ZipCodesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZipCode>>> GetZipCodes()
        {
            IEnumerable<ZipCode> zipCodes = await _unitOfWork.ZipCodes.GetAll();

            return Ok(zipCodes);
        }
    }
}
