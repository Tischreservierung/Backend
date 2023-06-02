﻿using Core.Contracts;
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
        public async Task<ActionResult<RestaurantPicture>> PostPicture(List<string> pictureStrings, int restaurantId)
        {
            List<byte[]> pictures = StringToByteArray(pictureStrings);

            foreach(byte[] pic in pictures) {
                _unitOfWork.RestaurantPictures.PostPicture(pic, restaurantId);
            }
            
            await _unitOfWork.SaveChangesAsync();

            return Ok(pictures.Count());
        }

        private List<byte[]> StringToByteArray(List<string> pictureStrings)
        {
            List<byte[]> ret = new List<byte[]>();
            
            foreach(string pictureString in pictureStrings)
            {
                ret.Add(Convert.FromBase64String(pictureString));
            }

            return ret;
        }
    }
}
