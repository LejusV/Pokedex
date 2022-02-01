using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    internal class Battle
    {
        private static Trainer _trainer;


        public Battle(Trainer trainer, Pokemon[] trainer_poks, Pokemon[] ennemy_poks)
        {
            Console.WriteLine("A new battle is about to happen !");
        }
    }
}
