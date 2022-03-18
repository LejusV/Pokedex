using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lairon Species to store common natural stats of all Lairons
	#region SpeciesLairon
	public class SpeciesLairon : PokemonSpecies
	{
#nullable enable
		private static SpeciesLairon? _instance = null;
#nullable restore
        public static SpeciesLairon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLairon();
                }
                return _instance;
            }
        }

		#region SpeciesLairon Constructor
		public SpeciesLairon() : base(
			305,
			"Lairon",
			0.9,
			120.0,
			60, // HPs
			90, 140, // Attack & Defense
			50, 50, // Special Attack & Defense
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
				"Cut",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Metal-Burst",
				"Magnet-Rise",
				"Rock-Polish",
				"Earth-Power",
				"Shadow-Claw",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Autotomize",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Lairon PokemonInstance Class
	#region Lairon
	public class LaironInstance : PokemonInstance
	{
		#region Lairon Constructors
		/// <summary>
		/// Lairon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LaironInstance(string nickname, int level)
		: base(
				SpeciesLairon.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lairon Builder only waiting for a Level
		/// </summary>
		public LaironInstance(int level)
		: base(
				SpeciesLairon.Instance, // PokemonInstance Species
				"Lairon", level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lairon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LaironInstance() : base(
			SpeciesLairon.Instance, // PokemonInstance Species
			Steel.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}