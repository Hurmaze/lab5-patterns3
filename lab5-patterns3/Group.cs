using lab5_patterns3.Interfaces;
using System;
namespace Lab5_behaviouralPatterns
{
    public class Group : Sprite
    {
        protected List<Sprite> _sprite = new List<Sprite>();

        public Group()
        {
        }

        public override void SetMotionType(IMovable movable)
        {
            for (int i = 0; i < _sprite.Count(); i++)
            {
                _sprite[i].SetMotionType(movable);
            }
        }

        public void Add(Sprite sprite)
        {
            this._sprite.Add(sprite);
        }

        public void Remove(Sprite sprite)
        {
            this._sprite.Remove(sprite);
        }

        public override string Move()
        {
            string output = $" Group {this._movementStrategy?.Move()}\n ";
            foreach (Sprite sprite in _sprite)
            {
                output += $"{sprite.Move()} \n";
            }

            return output;
        }

        public static void AddToGroup(Group group, Sprite sprite)
        {
                group?.Add(sprite);
        }
    }
}

