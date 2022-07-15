using eRestoran.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace eRestoran.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreporukeController : ControllerBase
    {
        private readonly IPreporukaService _preporukaService;

        public PreporukeController(IPreporukaService service)
        {
            _preporukaService = service;

        }

        [HttpGet("{id}")]
        public List<Model.Jela> Get(int id)
        {
            return _preporukaService.GetPreporuka(id);

        }

    }
}
