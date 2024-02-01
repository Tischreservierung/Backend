using Core.Contracts;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantPictureController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RestaurantPictureController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("profil")]
        public async Task<ActionResult<RestaurantPicture>> GetProfilPicture(int restaurantId)
        {
            var pic = await _unitOfWork.RestaurantPictures.GetFirstPictureByRestaurantId(restaurantId);

            if (pic == null)
            {
                return NotFound();
            }

            return Ok(pic);
        }

        [HttpGet("pictures")]
        public async Task<ActionResult<RestaurantPicture>> GetPictures(int restaurantId)
        {
            var pic = await _unitOfWork.RestaurantPictures.GetPicturesByRestaurantId(restaurantId);

            if (pic == null)
            {
                return NotFound();
            }

            return Ok(pic);
        }

        [HttpPost]
        [RequestSizeLimit(100_000_000)]
        public async Task<ActionResult<RestaurantPicture>> PostPicture(List<string> pictureStrings, int restaurantId)
        {
            List<byte[]> pictures = StringToByteArray(pictureStrings);
            int count = _unitOfWork.RestaurantPictures.CountPicture(restaurantId);

            foreach (byte[] pic in pictures) {
                RestaurantPicture resPicture = new() { Picture = pic, Index = count, RestaurantId = restaurantId };
                _unitOfWork.RestaurantPictures.PostPicture(resPicture);
                count++;
            }
            
            await _unitOfWork.SaveChangesAsync();

            return Ok(pictures.Count);
        }

        private static List<byte[]> StringToByteArray(List<string> pictureStrings)
        {
            List<byte[]> ret = new();
            
            foreach(string pictureString in pictureStrings)
            {
                ret.Add(Convert.FromBase64String(pictureString));
            }

            return ret;
        }
    }
}
