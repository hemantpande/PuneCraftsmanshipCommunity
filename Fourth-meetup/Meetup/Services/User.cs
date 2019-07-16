using System;

namespace Services
{
    public class User
    {
        public MembershipPlan Plan { get; internal set; }
        public Guid Id { get; internal set; }
    }
}