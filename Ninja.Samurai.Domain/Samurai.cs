using Ninja.Samurai.Domain.Interfaces;
using Ninject;

namespace Ninja.Samurai.Domain
{
    public class Samurai : IWarrior
    {
        private readonly IWeapon _weapon;
        [Inject]
        public Samurai(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack(string target)
        {
           _weapon.Hit(target);
        }
    }
}