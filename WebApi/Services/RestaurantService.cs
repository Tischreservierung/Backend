﻿using Core.Contracts;
using Core.Dto;
using Core.Models;
using Core.Paging;

namespace WebApi.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<Restaurant> CreateRestaurant(RestaurantPostDto dto)
        {
            Restaurant restaurant = new()
            {
                Name = dto.Name,
                Address = dto.Address,
                StreetNr = dto.StreetNr,
                ZipCodeId = dto.ZipCode!.Id,
                Description = dto.Description,
            };

            RestaurantOpeningTime[] openingTimes = GetOpeningTimes(dto.Openings, restaurant);
            RestaurantPicture[] pictures = StringToByteArray(dto.Pictures, restaurant);

            _unitOfWork.Restaurants.Insert(restaurant);
            _unitOfWork.OpeningTimes.InsertAll(openingTimes);
            _unitOfWork.RestaurantPictures.InsertAll(pictures);
            await _unitOfWork.SaveChangesAsync();

            return restaurant;
        }

        private static RestaurantPicture[] StringToByteArray(string[] pictureStrings, Restaurant restaurant)
        {
            List<RestaurantPicture> pictures = new();

            for (int i = 0; i < pictureStrings.Length; i++)
            {
                pictures.Add(new RestaurantPicture()
                {
                    Picture = Convert.FromBase64String(pictureStrings[i]),
                    Index = i,
                    Restaurant = restaurant 
                });
            }

            return pictures.ToArray();
        }

        public async Task<Restaurant?> UpdateRestaurant(RestaurantUpdateDto dto)
        {
            Restaurant? restaurant = await _unitOfWork.Restaurants.GetById(dto.Id);

            if (restaurant == null)
            {
                return null;
            }

            restaurant.Name = dto.Name;
            restaurant.Address = dto.Address;
            restaurant.StreetNr = dto.StreetNr;
            restaurant.ZipCodeId = dto.ZipCode!.Id;
            restaurant.Description = dto.Description;

            _unitOfWork.Restaurants.Update(restaurant);
            await _unitOfWork.SaveChangesAsync();

            return restaurant;
        }

        public Task<PagedList<RestaurantViewDto>> GetRestaurants(string searchString, int seatPlaces, DateTime day, TimeSpan time, Category[] categories, ZipCode[] zipCodes)
        {
            throw new NotImplementedException();
        }

        private static RestaurantOpeningTime[] GetOpeningTimes(OpeningTimeDto[] dto, Restaurant restaurant)
        {
            return dto.Select(o => new RestaurantOpeningTime()
            {
                Day = (DayOfWeek)o.Day,
                OpeningTime = new TimeSpan(int.Parse(o.OpenFrom.Split(':')[0]), int.Parse(o.OpenFrom.Split(':')[1]), 0),
                ClosingTime = new TimeSpan(int.Parse(o.OpenTo.Split(':')[0]), int.Parse(o.OpenTo.Split(':')[1]), 0),
                Restaurant = restaurant
            }).ToArray();
        }
    }
}
