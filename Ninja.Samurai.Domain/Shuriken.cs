using System;
using Ninja.Samurai.Domain.Interfaces;
using Ninject;

namespace Ninja.Samurai.Domain
{
  
    public class Shuriken :IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Pieces {0} the armor",target);
        }
    }
}