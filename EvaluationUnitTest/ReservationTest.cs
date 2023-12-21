using EvaluationSampleCode;

namespace EvaluationUnitTest
{
    [TestClass]
    public class Reservation
    {
        [TestMethod]
        public void Reservation_WhenCalled_SetsMadeByProperty()
        {
            User user = new User("Remi Theo");
            Reservation reservation = new Reservation(user);
            Assert.AreEqual(user, reservation.MadeBy);
        }
    }
}