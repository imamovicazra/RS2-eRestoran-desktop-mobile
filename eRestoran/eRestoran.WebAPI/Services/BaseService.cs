using AutoMapper;
using eRestoran.WebAPI.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    [Authorize]
    public class BaseService<TModel, TSearch, TDatabase> : IBaseService<TModel, TSearch> where TDatabase : class
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;

        public BaseService(eRestoranContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<List<TModel>> Get(TSearch search)
        {
            var list = await _context.Set<TDatabase>().ToListAsync();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual async Task<TModel> GetById(int id)
        {
            var entity = await _context.Set<TDatabase>().FindAsync(id);
            return _mapper.Map<TModel>(entity);
        }

        protected virtual IQueryable<TDatabase> ApplyFilter(IQueryable<TDatabase> query, TSearch search)
        {
            return query;
        }

    }
}

