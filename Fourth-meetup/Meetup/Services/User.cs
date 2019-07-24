using System;

namespace Services
{
    public class User
    {
        public MembershipPlan Plan { get; set; }
        public Guid Id { get; set; }
        public int LocationId { get; internal set; }
    }
}