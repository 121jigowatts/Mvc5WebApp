using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mvc5WebApp.Contracts;
using Mapper = AutoMapper.Mapper;

namespace Mvc5WebApp.MapperAutoMapper
{
    public class AutoMapperServicesConfiguration : Mvc5WebApp.Contracts.IObjectMapper
    {
        public static void Configure()
        {
            ConfigureUserMapping();

        }

        private static void ConfigureUserMapping()
        {
            //Mapper.CreateMap<SQLServerRepositories.Database.Person, Models.Person>();
        }

        public TDestination Map<TDestination>(object source)
        {
            return Mapper.Map<TDestination>(source);
        }
    }
}
