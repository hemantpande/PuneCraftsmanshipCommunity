using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services;

namespace Tuesday_Services.Tests
{
    [TestClass]
    public class SchedulerTests
    {
        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void CannotScheduleWithoutTitle(string topic)
        {
            var scheduler = new Scheduler();
            Action act = () => scheduler.ScheduleMeetup(new User(), topic,
                "Something", DateTime.Now, 10, 10001);
            var ex = Assert.ThrowsException<ArgumentException>(act);
            Assert.AreEqual(ex.ParamName, "topic");
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void CannotScheduleWithoutDescription(string description)
        {
            var scheduler = new Scheduler();
            Action act = () => scheduler.ScheduleMeetup(new User(),
                "Something", description, DateTime.Now, 10, 10001);
            var ex = Assert.ThrowsException<ArgumentException>(act);
            Assert.AreEqual(ex.ParamName, "description");
        }

        [TestMethod]
        public void CannotScheduleForPastDate()
        {
            var scheduler = new Scheduler();
            Action act = () => scheduler.ScheduleMeetup(new User(), "Something", "SomeDescription", DateTime.Now.AddDays(-1), 10, 10001);
            var ex = Assert.ThrowsException<ArgumentException>(act);
            Assert.AreEqual(ex.ParamName, "date");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CannotScheduleWithoutUser()
        {
            var scheduler = new Scheduler();

            scheduler.ScheduleMeetup(null, "Something", "SomeDescription", DateTime.Now.AddDays(1), 10, 10001);
        }

        [TestMethod]
        public void CannotScheduleForMoreThanTenParticipantsWithFreePlan()
        {
            var scheduler = new Scheduler();

            Action act = () => scheduler.ScheduleMeetup(new User(), "Something", "SomeDescription", DateTime.Now.AddDays(1), 13, 10001);

            var ex = Assert.ThrowsException<Exception>(act);

            Assert.AreEqual("Free plan can only have up to 10 participants.", ex.Message);
        }

        [TestMethod]
        public void CannotScheduleWithoutLocation()
        {
            var scheduler = new Scheduler();
            var user = new User { Plan = MembershipPlan.Free };

            Action act = () => scheduler.ScheduleMeetup(user, "Something", "SomeDescription", DateTime.Now.AddDays(1), 10, 0);

            var ex = Assert.ThrowsException<ArgumentException>(act);

            Assert.AreEqual("locationId", ex.ParamName);
        }

        [TestMethod]
        public void CanScheduleMeetup()
        {
            var meetupDataMock = new Mock<IMeetupData>();
            meetupDataMock.Setup(x => x.Create(It.IsAny<Guid>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<DateTime>(),
               5)).Returns(1);

            var locationDataMock = new Mock<ILocationData>();

            var scheduler = new Scheduler(meetupDataMock.Object, locationDataMock.Object);
            var identifier = Guid.NewGuid();
            var user = new User { Id = identifier };

            string topic = "ReactJS";
            string description = "ReactJS in July";

            scheduler.ScheduleMeetup(user, topic, description, DateTime.Today, 5, 1);

            meetupDataMock.Verify(x => x.Create(identifier, topic, description, DateTime.Today, 5));
        }

        [TestMethod]
        public void CannotScheduleMeetupWhenDbHasSomeProblem()
        {
            var meetupDataMock = new Mock<IMeetupData>();
            meetupDataMock.Setup(x => x.Create(It.IsAny<Guid>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<DateTime>(),
               5)).Returns(0);

            var locationDataMock = new Mock<ILocationData>();

            var scheduler = new Scheduler(meetupDataMock.Object, locationDataMock.Object);
            var identifier = Guid.NewGuid();
            var user = new User { Id = identifier };

            string topic = "ReactJS";
            string description = "ReactJS in July";

            Action act = () => scheduler.ScheduleMeetup(user, topic, description, DateTime.Today, 5, 1);

            var ex = Assert.ThrowsException<Exception>(act);

            Assert.AreEqual("Failed to create meetup.", ex.Message);
        }
    }
}