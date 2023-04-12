﻿using AutoMapper;using TransportManagment.Classes;using TransportManagment.Server.Dto;namespace TransportManagment.Server;
/// <summary>
/// Class for AutoMapper
/// </summary>public class MappingProfile : Profile{
    /// <summary>
    /// Constructor
    /// </summary>    public MappingProfile()     {        CreateMap<Classes.Route, RouteGetDto>();        CreateMap<RoutePostDto, Classes.Route>();        CreateMap<Transport, TransportGetDto>();        CreateMap<TransportPostDto, Transport>();
        CreateMap<Driver, DriverGetDto>();        CreateMap<DriverPostDto, Driver>();    }}