﻿using AutoMapper;using TransportManagment.Classes;using TransportManagment.Server.Dto;namespace TransportManagment.Server;public class MappingProfile : Profile{    public MappingProfile()     {        CreateMap<Classes.Route, RouteGetDto>();        CreateMap<RoutePostDto, Classes.Route>();
        //CreateMap<Classes.Route, RoutePostDto>();
        CreateMap<Transport, TransportGetDto>();        CreateMap<TransportPostDto, Transport>();
        //CreateMap<Transport, TransportPostDto>();
        CreateMap<Driver, DriverGetDto>();        CreateMap<DriverPostDto, Driver>();
        //CreateMap<Driver, DriverGetDto>();    }}