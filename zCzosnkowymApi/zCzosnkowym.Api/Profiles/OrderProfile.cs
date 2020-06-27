using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zCzosnkowym.Api.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<DataAccess.Entities.Order, Models.OrderDto>();
               
        }
    }
}