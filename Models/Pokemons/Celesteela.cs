using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Celesteela Species to store common natural stats of all Celesteelas
	#region SpeciesCelesteela
	public class SpeciesCelesteela : PokemonSpecies
	{
#nullable enable
		private static SpeciesCelesteela? _instance = null;
#nullable restore
        public static SpeciesCelesteela Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCelesteela();
                }
                return _instance;
            }
        }

		#region SpeciesCelesteela Constructor
		public SpeciesCelesteela() : base(
			"Celesteela",
			9.2,
			999.9,
			97, // HPs
			101, 103, // Attack & Defense
			107, 101, // Special Attack & Defense
			61		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Fly",
				"Tackle",
				"Double-Edge",
				"Flamethrower",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Harden",
				"Fire-Blast",
				"Skull-Bash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Facade",
				"Ingrain",
				"Metal-Sound",
				"Iron-Defense",
				"Gyro-Ball",
				"Seed-Bomb",
				"Air-Slash",
				"Energy-Ball",
				"Giga-Impact",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Wide-Guard",
				"Autotomize",
				"Smack-Down",
				"Heavy-Slam",
				"Flame-Charge",
				"Round",
				"Acrobatics",
				"Bulldoze",
				"Confide",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Celesteela PokemonInstance Class
	#region Celesteela
	public class CelesteelaInstance : PokemonInstance
	{
		#region Celesteela Constructors
		/// <summary>
		/// Celesteela Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CelesteelaInstance(string nickname, int level)
		: base(
				797,
				SpeciesCelesteela.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celesteela Builder only waiting for a Level
		/// </summary>
		public CelesteelaInstance(int level)
		: base(
				797,
				SpeciesCelesteela.Instance, // PokemonInstance Species
				"Celesteela", level,
				Steel.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celesteela Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Celesteela() : base(
			797,
			SpeciesCelesteela.Instance, // PokemonInstance Species
			Steel.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}