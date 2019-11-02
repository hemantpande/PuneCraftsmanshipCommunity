
using System;
using Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Services.UnitTests
{
    [TestClass]
    public class RegistrationTest
    {
        [TestMethod]
        public void CheckifFreeUserCannotRegisterbeforeTenDays()
        {
            var user = new User();
            user.Plan = MembershipPlan.Free;
            user.Id = new System.Guid();
            user.LocationId = 1;

            var meetupdataMock = new Mock<IMeetupData>();
            meetupdataMock.Setup(meetupDataObject => meetupDataObject.Get(It.IsAny<uint>())).Returns(new Meetup() { Date = DateTime.Now.AddDays(11) });

            Registration registration = new Registration(meetupdataMock.Object);
            Action act = () => registration.SignUp(1, user);

            var exception = Assert.ThrowsException<Exception>(act);
            Assert.AreEqual("You can sign up for meetups only in the last 10 days before start. Upgrade otherwise.", exception.Message);
        }
    }
}
