using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zCzosnkowym.Api.Profiles
{
    public class RestaurantProfile : Profile
    {
        public RestaurantProfile()
        {
            CreateMap<DataAccess.Entities.Restaurant, Models.RestaurantDto>();
        }
    }
}
