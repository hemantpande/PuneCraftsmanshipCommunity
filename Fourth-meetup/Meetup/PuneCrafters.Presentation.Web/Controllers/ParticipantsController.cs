using System;
using System.Web.Mvc;
using PuneCrafters.Business;
using PuneCrafters.Domain;

namespace PuneCrafters.Presentation.Web.Controllers
{
    public class ParticipantsController : Controller
    {
        [HttpPost]
        public ActionResult SignUp(int id)
        {
            try
            {
                var participant = new MeetupParticipant
                {
                    MeetupId = id,
                    RegistrationDate = DateTime.Now,
                    UserId = DataStore.GetParticipant().Id
                };

                var registration = new Registration();
                registration.SignupForMeetup(participant);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult SignupForMeetup()
        {
            return View(DataStore.GetMeetups());
        }
    }
}