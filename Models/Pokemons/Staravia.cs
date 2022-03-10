using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Staravia Species to store common natural stats of all Staravias
	#region SpeciesStaravia
	public class SpeciesStaravia : PokemonSpecies
	{
#nullable enable
		private static SpeciesStaravia? _instance = null;
#nullable restore
        public static SpeciesStaravia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStaravia();
                }
                return _instance;
            }
        }

		#region SpeciesStaravia Constructor
		public SpeciesStaravia() : base(
			"Staravia",
			0.6,
			15.5,
			55, // HPs
			75, 50, // Attack & Defense
			40, 40, // Special Attack & Defense
			80		
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
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Tackle",
				"Take-Down",
				"Growl",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Swift",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Brave-Bird",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Final-Gambit",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Staravia PokemonInstance Class
	#region Staravia
	public class StaraviaInstance : PokemonInstance
	{
		#region Staravia Constructors
		/// <summary>
		/// Staravia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StaraviaInstance(string nickname, int level)
		: base(
				397,
				SpeciesStaravia.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staravia Builder only waiting for a Level
		/// </summary>
		public StaraviaInstance(int level)
		: base(
				397,
				SpeciesStaravia.Instance, // PokemonInstance Species
				"Staravia", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staravia Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Staravia() : base(
			397,
			SpeciesStaravia.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}