﻿using AutoMapper;
using dziennik_elektroniczny.Application.Mapping;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Application.ViewModels.VmForEdit
{
    public class EditGeography1AVm : IMapFrom<_1AGeography>
    {
        public int Id { get; set; }
        public double TestAvarage { get; set; }
        public double ShortQuizAvarage { get; set; }
        public double HomeworkAvarage { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<EditGeography1AVm, _1AGeography>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.TestAvarage, opt => opt.MapFrom(s => s.TestAvarage))
                .ForMember(d => d.ShortQuizAvarage, opt => opt.MapFrom(s => s.ShortQuizAvarage))
                .ForMember(d => d.HomeworkAvarage, opt => opt.MapFrom(s => s.HomeworkAvarage))
                .ReverseMap();
        }
    }
}