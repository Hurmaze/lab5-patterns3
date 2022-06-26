using lab5_patterns3.Interfaces;

namespace lab5_patterns3.Movement
{
    public class Running : IMovable
    {
        public Running()
        {
        }

        public string Move() => " is running";
    }
}

