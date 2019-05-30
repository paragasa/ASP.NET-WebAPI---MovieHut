using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MovieHut.Dtos;
using MovieHut.Models;

namespace MovieHut.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();

            //TODO create mapping for Movies
        }
    }
}