namespace Practice_Exercises
{
    public class Dictionary
    {
        Dictionary<string, Location> terorist = new Dictionary<string, Location>();
        Location location = new Location { X = 3, Y = 4 };

        // add new values to the dictionary
        public void Add(string name, Location location)
        {
            terorist.Add(name, location);
        }
    }

    public class Location
    {
        public int X { get; set; }

        public int Y { get; set; }

    }
}
