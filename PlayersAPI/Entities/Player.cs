using PlayersAPI.Enums;

namespace PlayersAPI.Entities
{
    public class Player
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public int Telefone { get; set; }
        public required string Nickname { get; set; }
        public HeroGroup MyProperty { get; set; }
    }
}
