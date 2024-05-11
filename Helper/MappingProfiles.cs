using AutoMapper;
using webapi.Dto;
using webapi.models;

namespace webapi.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            /*CreateMap<Pokemon, PokemonDto>().ReverseMap();*/
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<Owner,OwnerDto>();
            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto, Review>();
            CreateMap<Reviewer,ReviewerDto>();
        }
    }
}
