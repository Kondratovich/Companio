﻿using AutoMapper;
using Companio.DTO;
using Companio.Models;

namespace Companio.AutoMapper;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        ConfigureFromDomainToDto();
        ConfigureFromDtoToDomain();
    }

    private void ConfigureFromDomainToDto()
    {
        CreateMap<Project, ProjectReadDTO>();
        CreateMap<Team, TeamReadDTO>();
    }

    private void ConfigureFromDtoToDomain()
    {
        CreateMap<ProjectDTO, Project>();
        CreateMap<TeamDTO, Team>();
    }
}