using System;

namespace PuneCrafters.Domain
{
    public class User
    {
        public static int NextAvailableId { get; private set; }

        public User()
        {
            ++NextAvailableId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int LocationId { get; set; }
        public string Role { get; set; }
    }
}
