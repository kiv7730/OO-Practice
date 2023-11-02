namespace OOPractice
{
    public class Vehicle
    {
        private readonly string Unit = "km/h";
        private string Name { get; set; }
        private double Speed { get; set; }
        private Engine Engine { get; set; }
        public Vehicle() { }
        public Vehicle(string name, double speed)
        {
            Name = name;
            Speed = speed;
        }
        public Vehicle(string name, Engine engine)
        {
            Name = name;
            Engine = engine;
            Speed = engine.Speed();
        }
        public string SpeedUp()
        {
           
            return Name + ": " +Speed + Unit;
        }
    }
}