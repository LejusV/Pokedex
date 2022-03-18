using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Starly Species to store common natural stats of all Starlys
	#region SpeciesStarly
	public class SpeciesStarly : PokemonSpecies
	{
#nullable enable
		private static SpeciesStarly? _instance = null;
#nullable restore
        public static SpeciesStarly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStarly();
                }
                return _instance;
            }
        }

		#region SpeciesStarly Constructor
		public SpeciesStarly() : base(
			396,
			"Starly",
			0.3,
			2.0,
			40, // HPs
			55, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			60		
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
				"Sand-Attack",
				"Fury-Attack",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Mirror-Move",
				"Swift",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Revenge",
				"Endeavor",
				"Secret-Power",
				"Feather-Dance",
				"Astonish",
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
				"Final-Gambit",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Starly PokemonInstance Class
	#region Starly
	public class StarlyInstance : PokemonInstance
	{
		#region Starly Constructors
		/// <summary>
		/// Starly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StarlyInstance(string nickname, int level)
		: base(
				SpeciesStarly.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starly Builder only waiting for a Level
		/// </summary>
		public StarlyInstance(int level)
		: base(
				SpeciesStarly.Instance, // PokemonInstance Species
				"Starly", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starly Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public StarlyInstance() : base(
			SpeciesStarly.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}