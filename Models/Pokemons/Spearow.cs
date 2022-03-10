using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Spearow Species to store common natural stats of all Spearows
	#region SpeciesSpearow
	public class SpeciesSpearow : PokemonSpecies
	{
#nullable enable
		private static SpeciesSpearow? _instance = null;
#nullable restore
        public static SpeciesSpearow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSpearow();
                }
                return _instance;
            }
        }

		#region SpeciesSpearow Constructor
		public SpeciesSpearow() : base(
			"Spearow",
			0.3,
			2.0,
			40, // HPs
			60, 30, // Attack & Defense
			31, 31, // Special Attack & Defense
			70		
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
				"Razor-Wind",
				"Whirlwind",
				"Fly",
				"Fury-Attack",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Growl",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Mirror-Move",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Mud-Slap",
				"Detect",
				"Endure",
				"False-Swipe",
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
				"Assurance",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Spearow PokemonInstance Class
	#region Spearow
	public class SpearowInstance : PokemonInstance
	{
		#region Spearow Constructors
		/// <summary>
		/// Spearow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SpearowInstance(string nickname, int level)
		: base(
				21,
				SpeciesSpearow.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spearow Builder only waiting for a Level
		/// </summary>
		public SpearowInstance(int level)
		: base(
				21,
				SpeciesSpearow.Instance, // PokemonInstance Species
				"Spearow", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spearow Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Spearow() : base(
			21,
			SpeciesSpearow.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}