using AutoMapper;
using Mobiroller.Core.DTOs;
using Mobiroller.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiroller.Service
{
    public class DtoMapper :Profile
    {
        public DtoMapper()
        {
            CreateMap<UserAppDto, AppUser>().ReverseMap();
        }
    }
}
