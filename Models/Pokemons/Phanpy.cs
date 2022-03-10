using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Phanpy Species to store common natural stats of all Phanpys
	#region SpeciesPhanpy
	public class SpeciesPhanpy : PokemonSpecies
	{
#nullable enable
		private static SpeciesPhanpy? _instance = null;
#nullable restore
        public static SpeciesPhanpy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPhanpy();
                }
                return _instance;
            }
        }

		#region SpeciesPhanpy Constructor
		public SpeciesPhanpy() : base(
			"Phanpy",
			0.5,
			33.5,
			90, // HPs
			60, 60, // Attack & Defense
			40, 40, // Special Attack & Defense
			40		
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
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Water-Gun",
				"Counter",
				"Strength",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Natural-Gift",
				"Last-Resort",
				"Seed-Bomb",
				"Earth-Power",
				"Ice-Shard",
				"Gunk-Shot",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Heavy-Slam",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Play-Rough",
				"Confide",
				"High-Horsepower"
			};
		}
		#endregion
	}
	#endregion

	//Phanpy PokemonInstance Class
	#region Phanpy
	public class PhanpyInstance : PokemonInstance
	{
		#region Phanpy Constructors
		/// <summary>
		/// Phanpy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PhanpyInstance(string nickname, int level)
		: base(
				231,
				SpeciesPhanpy.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phanpy Builder only waiting for a Level
		/// </summary>
		public PhanpyInstance(int level)
		: base(
				231,
				SpeciesPhanpy.Instance, // PokemonInstance Species
				"Phanpy", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phanpy Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Phanpy() : base(
			231,
			SpeciesPhanpy.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}