using System;
using Ninja.Samurai.Domain.Interfaces;

namespace Ninja.Samurai.Domain
{
    public class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chopped {0} clean in half", target);
        }
    }
}