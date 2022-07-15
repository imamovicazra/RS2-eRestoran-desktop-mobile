﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase
    {
        private readonly IBaseService<T, TSearch> _service;
        public BaseController(IBaseService<T, TSearch> service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<List<T>> Get([FromQuery] TSearch search)
        {
            return await _service.Get(search);
        }

        [HttpGet("{id}")]
        public async Task<T> GetById(int id)
        {
            return await _service.GetById(id);
        }
    }
}
