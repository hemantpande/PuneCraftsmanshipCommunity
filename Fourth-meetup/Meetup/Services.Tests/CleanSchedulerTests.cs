using System;
using Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Services.Tests
{
    [TestClass]
    public class CleanSchedulerTests
    {
        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void CannotScheduleWithoutTopic(string topic)
        {
            // Arrange.
            var scheduler = new CleanScheduler(null, null);

            // Act.
            Action act = () => scheduler.ScheduleMeetup(null, topic, null, DateTime.MinValue, 0, 0);

            // Assert.
            var exception = Assert.ThrowsException<ArgumentException>(act);
            Assert.AreEqual("topic", exception.ParamName);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void CannotScheduleWithoutDescription(string description)
        {
            // Arrange.
            var scheduler = new CleanScheduler(null, null);

            // Act.
            Action act = () => scheduler.ScheduleMeetup(null, "sometopic", description, DateTime.MinValue, 0, 0);

            // Assert.
            var exception = Assert.ThrowsException<ArgumentException>(act);
            Assert.AreEqual("description", exception.ParamName);
        }

        [TestMethod]
        public void CannotScheduleForPastDate()
        {
            // Arrange.
            var scheduler = new CleanScheduler(null, null);
            var pastDate = DateTime.Today.AddDays(-1);

            // Act.
            Action act = () => scheduler.ScheduleMeetup(null, "sometopic", "somedescription", pastDate, 0, 0);

            // Assert.
            var exception = Assert.ThrowsException<ArgumentException>(act);
            Assert.AreEqual("date", exception.ParamName);
        }

        [TestMethod]
        public void CannotScheduleWithoutSchedulingUser()
        {
            // Arrange.
            var scheduler = new CleanScheduler(null, null);

            // Act.
            Action act = () => scheduler.ScheduleMeetup(user: null, "sometopic", "somedescription", DateTime.Today, 0, 0);

            // Assert.
            var exception = Assert.ThrowsException<NullReferenceException>(act);
        }

        [TestMethod]
        public void CannotScheduleForMoreThanTenParticipantsWithFreePlan()
        {
            // Arrange.
            var scheduler = new CleanScheduler(null, null);
            var userWithFreePlan = new User { Plan = MembershipPlan.Free };

            // Act.
            Action act = () => scheduler.ScheduleMeetup(userWithFreePlan, "sometopic", "somedescription", DateTime.Today, maxParticipants: 11, 0);

            // Assert.
            var exception = Assert.ThrowsException<System.Exception>(act);
            Assert.AreEqual("Free plan can only have up to 10 participants.", exception.Message);
        }

        [TestMethod]
        public void CannotScheduleForMoreThan50ParticipantsWithSilverPlan()
        {
            // Arrange.
            var scheduler = new CleanScheduler(null, null);
            var userWithFreePlan = new User { Plan = MembershipPlan.Silver };

            // Act.
            Action act = () => scheduler.ScheduleMeetup(userWithFreePlan, "sometopic", "somedescription", DateTime.Today, maxParticipants: 51, 0);

            // Assert.
            var exception = Assert.ThrowsException<System.Exception>(act);
            Assert.AreEqual("Silver plan can only have up to 50 participants.", exception.Message);
        }

        [TestMethod]
        public void CannotScheduleWithoutLocation()
        {
            // Arrange.
            var scheduler = new CleanScheduler(null, null);

            // Act.
            Action act = () => scheduler.ScheduleMeetup(new User(), "sometopic", "somedescription", DateTime.Today, 0, locationId: 0);

            // Assert.
            var exception = Assert.ThrowsException<System.ArgumentException>(act);
            Assert.AreEqual("locationId", exception.ParamName);
        }

        [TestMethod]
        public void MeetupDataIsCreatedOnSchedule()
        {
            // Arrange.
            var meetupDataMock = new Mock<IMeetupData>();
            meetupDataMock.Setup(m => m.Create(It.IsAny<Guid>(), It.IsAny<string>(), It.IsAny<string>(), DateTime.Today, 1)).Returns(1);
            
            var scheduler = new CleanScheduler(meetupDataMock.Object, new Mock<ILocationData>().Object);
            var user = new User { Id = Guid.Parse("34759A65-1F09-437B-9E2C-C193E73CA959") };
            string topic = "sometopic";
            string description = "somedescription";

            // Act.
            scheduler.ScheduleMeetup(user, topic, description, DateTime.Today, 1, 1);

            // Assert.
            meetupDataMock.Verify(m => m.Create(user.Id, topic, description, DateTime.Today, 1));
        }

        //[TestMethod]
        //public void ShouldNotAddParticipantMoreThanTenIfPlanIsFree()
        //{
        //    // Arrange
        //    var scheduler = CreateScheduler();
        //    User user = new User();
        //    // Act
        //    try
        //    {
        //        scheduler.ScheduleMeetup(user, "ReactJS", "React JS in July", DateTime.Now.AddDays(12), 11, 1);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual("Free plan can only have up to 10 participants.", ex.Message);
        //    }
        //    // Assert
        //}

        //[TestMethod]
        //public void ShouldNotAddParticipantMoreThanFiftyIfPlanIsSilver()
        //{
        //    // Arrange
        //    var scheduler = CreateScheduler();
        //    User user = new User(MembershipPlan.Silver);
        //    // Act
        //    try
        //    {
        //        scheduler.ScheduleMeetup(user, "ReactJS", "React JS in July", DateTime.Now.AddDays(12), 52, 1);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual("Silver plan can only have up to 50 participants.", ex.Message);
        //    }
        //    // Assert
        //}

        //[TestMethod]
        //public void ShouldNotSchedulePastDate()
        //{
        //    // Arrange
        //    var scheduler = CreateScheduler();
        //    User user = new User();
        //    // Act
        //    try
        //    {
        //        scheduler.ScheduleMeetup(user, "ReactJS", "React JS in July", DateTime.Now.AddDays(-1), 52, 1);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual("Meetup must be tomorrow or later.", ex.Message);
        //    }
        //    // Assert
        //}

        //[TestMethod]
        //public void CannotHaveEmptyDescription()
        //{
        //    // Arrange
        //    var scheduler = CreateScheduler();
        //    User user = new User();
        //    // Act
        //    try
        //    {
        //        scheduler.ScheduleMeetup(user, "ReactJS", "", DateTime.Now.AddDays(-1), 52, 1);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual("Description is required.", ex.Message);
        //    }
        //    // Assert
        //}

        //[TestMethod]
        //public void CannotHaveEmptyTopic()
        //{
        //    // Arrange
        //    var scheduler = CreateScheduler();
        //    User user = new User();
        //    // Act
        //    try
        //    {
        //        scheduler.ScheduleMeetup(user, "", "Some description goes here", DateTime.Now.AddDays(-1), 52, 1);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual("Topic is required.", ex.Message);
        //    }
        //    // Assert
        //}

        //[TestMethod]
        //public void CannotHaveInvalidLocationId()
        //{
        //    // Arrange
        //    var scheduler = CreateScheduler();
        //    User user = new User();
        //    // Act
        //    try
        //    {
        //        scheduler.ScheduleMeetup(user, "React JS", "Some description goes here", DateTime.Now.AddDays(1), 05, 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual("A location is required.", ex.Message);
        //    }
        //    // Assert
        //}

        //[TestMethod]
        //public void ScheduleMeetup()
        //{
        //    // Arrange
        //    Mock<IMeetupRepository> mockMeetupRepository = new Mock<IMeetupRepository>();
        //    mockMeetupRepository.Setup(x => x.Create(It.IsAny<Meetup>())).Returns(101);

        //    var scheduler = new Scheduler(mockMeetupRepository.Object);
        //    User user = new User();

        //    scheduler.ScheduleMeetup(user, "React JS", "Some description goes here", DateTime.Now.AddDays(1), 05, 103476);

        //    // Assert
        //    mockMeetupRepository.Verify(x => x.Create(It.IsAny<Meetup>()));

        //}
    }
}