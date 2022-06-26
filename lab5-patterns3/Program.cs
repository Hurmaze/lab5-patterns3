

using lab5_patterns3.Movement;
using System;
namespace Lab5_behaviouralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Running Orc");
            Sprite orc1 = new Orc();
            orc1.SetMotionType(new Running());
            Console.WriteLine(orc1.Move());

            Console.WriteLine("Jumping orc");
            Sprite orc2 = new Orc();
            orc2.SetMotionType(new Jumping());
            Console.WriteLine(orc2.Move());

            Console.WriteLine("Flying elf");
            Sprite elf1 = new Elf();
            elf1.SetMotionType(new Flying());
            Console.WriteLine(elf1.Move());

            Console.WriteLine("Group with sprites");
            Group group = new Group();

            Group.AddToGroup(group, orc1);
            Group.AddToGroup(group, orc2);
            Group.AddToGroup(group, elf1);

            Console.WriteLine(group.Move());


            Console.WriteLine("Change group moving strategy");
            group.SetMotionType(new MagicFlying());
            Console.WriteLine(group.Move());

        }
    }
}

