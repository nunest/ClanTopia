namespace ClanTopia.Domain
{
    public class Clan
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public List<Interest>? Interests { get; set; }
        public required List<User> Admins { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }

    }
}
