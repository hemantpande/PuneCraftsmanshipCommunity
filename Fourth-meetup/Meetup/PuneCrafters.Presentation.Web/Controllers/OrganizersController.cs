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
                // TODO: Let's not have any organizer role. Any user can start a meetup, and then that user becomes the organizer. Users organization rights are affected by their membership.
                var organizer = DataStore.GetOrganizer();

                var meetup = new Meetup
                {
                    // TODO: Let's have the data store figure out the new ID after creating?
                    Id = Meetup.NextAvailableId,
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