using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Fearow Species to store common natural stats of all Fearows
	#region SpeciesFearow
	public class SpeciesFearow : PokemonSpecies
	{
#nullable enable
		private static SpeciesFearow? _instance = null;
#nullable restore
        public static SpeciesFearow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFearow();
                }
                return _instance;
            }
        }

		#region SpeciesFearow Constructor
		public SpeciesFearow() : base(
			"Fearow",
			1.2,
			38.0,
			65, // HPs
			90, 65, // Attack & Defense
			61, 61, // Special Attack & Defense
			100		
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
				"Hyper-Beam",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Mirror-Move",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
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
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Assurance",
				"Giga-Impact",
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

	//Fearow PokemonInstance Class
	#region Fearow
	public class FearowInstance : PokemonInstance
	{
		#region Fearow Constructors
		/// <summary>
		/// Fearow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FearowInstance(string nickname, int level)
		: base(
				22,
				SpeciesFearow.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fearow Builder only waiting for a Level
		/// </summary>
		public FearowInstance(int level)
		: base(
				22,
				SpeciesFearow.Instance, // PokemonInstance Species
				"Fearow", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fearow Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Fearow() : base(
			22,
			SpeciesFearow.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}