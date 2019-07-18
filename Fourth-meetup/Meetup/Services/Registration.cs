using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Registration
    {
        internal Meetup mUp;

        public void SignUp(uint meetup, User user)
        {
            if (meetup == 0)
            {
                throw new ArgumentException("Meetup is required.");
            }
            else if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            else
            {
                mUp = new MeetupData().Get(meetup);
                var ok = true;
                if (mUp.Date < DateTime.Now)
                {
                    throw new Exception("Past meetup.");
                }
                else if (mUp.Date > DateTime.Today.AddDays(10))
                {
                    if (user.Plan == MembershipPlan.Free)
                    {
                        throw new Exception("You can sign up for meetups only in the last 10 days for start. Upgrade otherwise.");
                    }
                }
                else if (mUp.Date > DateTime.Today.AddDays(30))
                {
                    if (user.Plan == MembershipPlan.Silver)
                    {
                        throw new Exception("You can sign up for meetups only in the last 30 days for start. Upgrade otherwise.");
                    }
                }

                // TODO: FIND DISTANCE BASED ON USER LOCATION AND MEETUP LOCATION.
                // USE THE DISTANCE AS A DATA WHEN WE ARE SIGNING UP THE USER.
                // A MEETUP ADMIN CAN SEE HOW FAR PEOPLE ARE READY TO TRAVEL FOR HIS/HER MEETUP.
                // FINISH REGISTRATION.
            }
        }
    }

}
