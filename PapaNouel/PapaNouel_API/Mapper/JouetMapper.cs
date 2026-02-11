using PapaNouel.Models;
using PapaNouel_API.DTOs;
using System.Runtime.CompilerServices;

namespace PapaNouel_API.Mapper
{
    public static class JouetMapper
    {
        public static JouetDTO ToDto(this IJouet jouets)
        {
            var JouetsDto = new JouetDTO();

            JouetsDto.Play = jouets.Play();
            JouetsDto.ObsolescenceProgramee = jouets.ObsolescenceProgramee();

            return JouetsDto;
        }
    }
}
