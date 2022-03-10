using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Torterra Species to store common natural stats of all Torterras
	#region SpeciesTorterra
	public class SpeciesTorterra : PokemonSpecies
	{
#nullable enable
		private static SpeciesTorterra? _instance = null;
#nullable restore
        public static SpeciesTorterra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTorterra();
                }
                return _instance;
            }
        }

		#region SpeciesTorterra Constructor
		public SpeciesTorterra() : base(
			"Torterra",
			2.2,
			310.0,
			95, // HPs
			109, 105, // Attack & Defense
			75, 85, // Special Attack & Defense
			56		
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Tackle",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Razor-Leaf",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Superpower",
				"Secret-Power",
				"Rock-Tomb",
				"Bullet-Seed",
				"Block",
				"Frenzy-Plant",
				"Natural-Gift",
				"Worry-Seed",
				"Rock-Polish",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Leaf-Storm",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Wood-Hammer",
				"Round",
				"Grass-Pledge",
				"Bulldoze",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Torterra PokemonInstance Class
	#region Torterra
	public class TorterraInstance : PokemonInstance
	{
		#region Torterra Constructors
		/// <summary>
		/// Torterra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TorterraInstance(string nickname, int level)
		: base(
				389,
				SpeciesTorterra.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torterra Builder only waiting for a Level
		/// </summary>
		public TorterraInstance(int level)
		: base(
				389,
				SpeciesTorterra.Instance, // PokemonInstance Species
				"Torterra", level,
				Grass.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torterra Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Torterra() : base(
			389,
			SpeciesTorterra.Instance, // PokemonInstance Species
			Grass.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}