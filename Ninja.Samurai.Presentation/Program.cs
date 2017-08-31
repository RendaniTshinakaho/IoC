using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninja.Samurai.Domain;
using Ninja.Samurai.Domain.Interfaces;
using Ninject;
using Ninject.Modules;

namespace Ninja.Samurai.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new WarriorModule());
            var samurai = kernel.Get<IWarrior>();
            samurai.Attack("Unwashed masses");
            Console.ReadKey();
        }
    }

    public class WarriorModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IWarrior>().To<Domain.Samurai>().InSingletonScope();
            Bind<IWeapon>().To<Sword>().InSingletonScope();
        }
    }
}
