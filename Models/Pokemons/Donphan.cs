using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Donphan Species to store common natural stats of all Donphans
	#region SpeciesDonphan
	public class SpeciesDonphan : PokemonSpecies
	{
#nullable enable
		private static SpeciesDonphan? _instance = null;
#nullable restore
        public static SpeciesDonphan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDonphan();
                }
                return _instance;
            }
        }

		#region SpeciesDonphan Constructor
		public SpeciesDonphan() : base(
			"Donphan",
			1.1,
			120.0,
			90, // HPs
			120, 120, // Attack & Defense
			60, 60, // Special Attack & Defense
			50		
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
				"Horn-Attack",
				"Fury-Attack",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Roar",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Rapid-Spin",
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
				"Iron-Defense",
				"Block",
				"Bounce",
				"Gyro-Ball",
				"Natural-Gift",
				"Assurance",
				"Last-Resort",
				"Rock-Polish",
				"Poison-Jab",
				"Seed-Bomb",
				"Earth-Power",
				"Giga-Impact",
				"Thunder-Fang",
				"Fire-Fang",
				"Gunk-Shot",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Donphan PokemonInstance Class
	#region Donphan
	public class DonphanInstance : PokemonInstance
	{
		#region Donphan Constructors
		/// <summary>
		/// Donphan Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DonphanInstance(string nickname, int level)
		: base(
				232,
				SpeciesDonphan.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Donphan Builder only waiting for a Level
		/// </summary>
		public DonphanInstance(int level)
		: base(
				232,
				SpeciesDonphan.Instance, // PokemonInstance Species
				"Donphan", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Donphan Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Donphan() : base(
			232,
			SpeciesDonphan.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}