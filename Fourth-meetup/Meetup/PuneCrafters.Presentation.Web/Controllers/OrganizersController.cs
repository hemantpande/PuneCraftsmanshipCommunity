using System.Linq;
using System.Web.Mvc;
using PuneCrafters.Business;
using PuneCrafters.Domain;
using PuneCrafters.Presentation.Web.Models;

namespace PuneCrafters.Presentation.Web.Controllers
{
    public class OrganizersController : Controller
    {
        public ActionResult Schedule()
        {
            return View();
        }

        public ActionResult ScheduledSuccess()
        {
            var recent = DataStore.GetMeetups().Last();
            return View(recent);
        }

        [HttpPost]
        public ActionResult Schedule(MeetupModel model)
        {
            try
            {
                var organizer = DataStore.GetOrganizer();

                var meetup = new Meetup
                {
                    Title = model.Title,
                    Date = model.Date,
                    Description = model.Description,
                    ParticipantsCount = model.ParticipantsCount,
                    LocationId = organizer.LocationId
                };

                Scheduler scheduler = new Scheduler();
                scheduler.ScheduleMeetup(meetup);
                return RedirectToAction("ScheduledSuccess");
            }
            catch
            {
                return View();
            }
        }
    }
}