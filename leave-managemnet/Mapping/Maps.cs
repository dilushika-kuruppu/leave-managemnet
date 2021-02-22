﻿using AutoMapper;
using leave_managemnet.Data;
using leave_managemnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managemnet.Mapping
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
      
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();

          

        }
    }
}
