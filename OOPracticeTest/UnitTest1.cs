namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();
            Assert.NotNull(class1);
        }

        [Fact]
        public void Should_return_correct_string_when_SpeedUp_given_a_car_with_name()
        {
            //given
            string name = "Cool Car";
            double speed = 30;
            Car car = new Car(name, speed);
            //when
            string result = car.SpeedUp();
            //then
            Assert.Equal("Cool Car: 30km/h", result);
        }

        [Fact]
        public void Should_return_correct_string_when_SpeedUp_given_a_truck_with_name()
        {
            //given
            string name = "Big Truck";
            double speed = 10;
            Truck truck = new Truck(name, speed);
            //when
            string result = truck.SpeedUp();
            //then
            Assert.Equal("Big Truck: 10km/h", result);
        }

        [Fact]
        public void Should_return_correct_string_when_Driver_drive_given_a_car()
        {
            Driver driver = new Driver();
            string result = driver.Drive(new Car("Cool Car", 30));
            Assert.Equal("Cool Car: 30km/h", result);

        }

        [Fact]
        public void Should_return_correct_string_when_Driver_drive_given_a_truck()
        {
            Driver driver = new Driver();
            string result = driver.Drive(new Truck("Big Truck", 10));
            Assert.Equal("Big Truck: 10km/h", result);

        }

        [Fact]
        public void Should_return_correct_string_when_Driver_drive_given_a_car_with_a_engine()
        {
            Driver driver = new Driver();
            string result = driver.Drive(new Car("Cool Car", new ElectricEngine()));
            Assert.Equal("Cool Car: 25km/h", result);
        }
    }
}
