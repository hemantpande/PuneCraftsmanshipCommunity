using System;

namespace Services
{
    public class User
    {
        public MembershipPlan Plan { get; internal set; }
        public Guid Id { get; internal set; }
        public int LocationId { get; internal set; }

        public User(MembershipPlan plan = MembershipPlan.Free)
        {
            Plan = plan;
        }
    }
}