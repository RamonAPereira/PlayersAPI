using PlayersAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace PlayersAPI.Entities
{
    public class Player
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public int Telefone { get; set; }
        [Key]
        public required string Nickname { get; set; }
        public HeroGroup group { get; set; }
    }
}
