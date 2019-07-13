namespace PuneCrafters.Domain
{
    public class User
    {
        public User()
        {
            ++NextAvailableId;
        }

        public static int NextAvailableId { get; private set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public MembershipPlan Plan { get; set; } = MembershipPlan.Free;
        public string Role { get; set; }
    }
}