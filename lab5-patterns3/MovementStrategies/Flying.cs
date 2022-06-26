using lab5_patterns3.Interfaces;
using System;
namespace lab5_patterns3.Movement
{
    public class Flying : IMovable
    {
        public Flying()
        {
        }

        public string Move() => " is flying";
    }
}

