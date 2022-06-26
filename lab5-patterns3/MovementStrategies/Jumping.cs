using lab5_patterns3.Interfaces;
using System;
namespace lab5_patterns3.Movement
{
    public class Jumping : IMovable
    {
        public Jumping()
        {
        }

        public string Move() => " is jumping";
    }
}

