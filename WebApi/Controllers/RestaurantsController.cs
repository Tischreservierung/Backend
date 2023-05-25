﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.RestaurantRepo;
using Core.Models;
using Core.Contracts;
using Core.DTO;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Tischreservierung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantRepository _repository;

        public RestaurantsController(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Restaurant>>> GetRestaurants()
        {
            var restaurants = await _repository.GetRestaurants();
            
            return Ok(restaurants);
        }

        [HttpGet("name")]
        public async Task<ActionResult<IEnumerable<Restaurant>>> GetRestauntsByName(string name, int zipCodeId)
        {
            var restaurants = await _repository.GetRestaurantsByName(name, zipCodeId);

            return Ok(restaurants);
        }

        [HttpGet("categories")]
        public async Task<ActionResult<IEnumerable<Restaurant>>> GetRestauntsByCategories
            ([FromQuery] int[] categorieIds, int zipCodeId)
        {
            var restaurants = await _repository.GetRestaurantsByCategories(categorieIds, zipCodeId);
            return Ok(restaurants);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
        {
            var restaurant = await _repository.GetRestaurantById(id);

            if (restaurant == null)
            {
                return NotFound();
            }

            return Ok(restaurant);
        }

        [HttpPost]
        public async Task<ActionResult<Restaurant>> PostRestaurant(DTO_RestaurantPost restaurant)
        {
            Restaurant? res = await _repository.InsertRestaurantAsync(restaurant);
            if (res == null)
                return BadRequest();
            await _repository.Save();
            return Ok(res.Id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRestaurant(int id)
        {
            var restaurant = await _repository.GetRestaurantById(id);
            if (restaurant == null)
            {
                return NotFound();
            }

            _repository.DeleteRestaurant(restaurant);
            await _repository.Save();

            return NoContent();
        }

        [HttpGet("restaurantview/{id}")]
        public async Task<ActionResult<RestaurantViewDto?>> GetRestaurantForView(int id)
        {
            return Ok(await _repository.GetRestaurantForViewById(id));
        }
    }
}