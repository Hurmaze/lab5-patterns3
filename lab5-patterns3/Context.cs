using lab5_patterns3.Interfaces;
using System;
namespace Lab5_behaviouralPatterns
{    
    public abstract class Sprite
    {
        protected IMovable _movementStrategy;

        public int CurrentPosition { get; protected set; }
        public int Speed { get; protected set; }

        public Sprite()
        {
        }

        public Sprite(IMovable motion)
        {
            this._movementStrategy = motion;
        }

        public virtual void SetMotionType(IMovable movable)
        {
            this._movementStrategy = movable;
        }

        public virtual string Move()
        {
            return _movementStrategy.Move();
        }

        public virtual bool IsGroup()
        {
            return true;
        }
    }
}

