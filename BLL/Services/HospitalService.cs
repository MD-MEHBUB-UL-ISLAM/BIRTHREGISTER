using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HospitalService
    {
        public static List<HospitalDTO> Get()
        {
            var dbdata = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Hosital_information, HospitalDTO>());
            var mapper = new Mapper(config);
            var groups = mapper.Map<List<HospitalDTO>>(dbdata);
            return groups;


        }
        public static HospitalDTO Get(int id)
        {
            var dbdata = DataAccessFactory.GroupDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Hosital_information, HospitalDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<HospitalDTO>(dbdata);
            return data;

        }
        public static HospitalDTO Add(HospitalDTO dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<  Hosital_information, HospitalDTO>();
                cfg.CreateMap<Hosital_information, HospitalDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<HospitalDTO>(dto);
            var result = DataAccessFactory.GroupDataAccess().Add(default);
            var rdata= mapper.Map<HospitalDTO>(result);
            return rdata;
        }


        public static HospitalDTO Delete(ChildinfoDTO dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Hosital_information, HospitalDTO>();
                cfg.CreateMap<Hosital_information, HospitalDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<HospitalDTO>(dto);
            var result = DataAccessFactory.GroupDataAccess().Delete(default);
            var rdata = mapper.Map<HospitalDTO>(result);
            return rdata;
        }
    }
    }

