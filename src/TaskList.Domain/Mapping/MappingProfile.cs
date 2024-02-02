using AutoMapper;
using TaskList.Domain.DTOs.Requests;

namespace TaskList.Domain.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateTaskRequestDto, Entities.Task>();
            CreateMap<UpdateTaskRequestDto, Entities.Task>();
        }
    }
}