using EvaluationSampleCode;

namespace EvaluationUnitTest
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void Reservation_WhenCalled_SetsMadeByProperty()
        {
            User user = new User();
            Reservation reservation = new Reservation(user);
            Assert.AreEqual(user, reservation.MadeBy);
        }
    }
}