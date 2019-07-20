using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Services.Tests
{
    [TestClass]
    public class SchedulerTest
    {
        [TestMethod]
        public void ShouldNotAddParticipantMoreThanTenIfPlanIsFree() 
        {
            // Arrange
            Scheduler scheduler = new Scheduler();
            User user = new User();
            // Act 
            try
            {
                scheduler.ScheduleMeetup(user, "ReactJS", "React JS in July", DateTime.Now.AddDays(12), 11, 1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Free plan can only have up to 10 participants.", ex.Message);
            }
            // Assert
        }

        [TestMethod]
        public void ShouldNotAddParticipantMoreThanFiftyIfPlanIsSilver()
        {
            // Arrange
            Scheduler scheduler = new Scheduler();
            User user = new User(MembershipPlan.Silver);
            // Act 
            try
            {
                scheduler.ScheduleMeetup(user, "ReactJS", "React JS in July", DateTime.Now.AddDays(12), 52, 1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Silver plan can only have up to 50 participants.", ex.Message);
            }
            // Assert
        }

        [TestMethod]
        public void ShouldNotSchedulePastDate()
        {
            // Arrange
            Scheduler scheduler = new Scheduler();
            User user = new User();
            // Act 
            try
            {
                scheduler.ScheduleMeetup(user, "ReactJS", "React JS in July", DateTime.Now.AddDays(-1), 52, 1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Meetup must be tomorrow or later.", ex.Message);
            }
            // Assert
        }

        [TestMethod]
        public void CannotHaveEmptyDescription()
        {
            // Arrange
            Scheduler scheduler = new Scheduler();
            User user = new User();
            // Act 
            try
            {
                scheduler.ScheduleMeetup(user, "ReactJS", "", DateTime.Now.AddDays(-1), 52, 1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Description is required.", ex.Message);
            }
            // Assert
        }

        [TestMethod]
        public void CannotHaveEmptyTopic()
        {
            // Arrange
            Scheduler scheduler = new Scheduler();
            User user = new User();
            // Act 
            try
            {
                scheduler.ScheduleMeetup(user, "", "Some description goes here", DateTime.Now.AddDays(-1), 52, 1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Topic is required.", ex.Message);
            }
            // Assert
        }

        [TestMethod]
        public void CannotHaveInvalidLocationId()
        {
            // Arrange
            Scheduler scheduler = new Scheduler();
            User user = new User();
            // Act 
            try
            {
                scheduler.ScheduleMeetup(user, "React JS", "Some description goes here", DateTime.Now.AddDays(1), 05, 0);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("A location is required.", ex.Message);
            }
            // Assert
        }
    }
}
