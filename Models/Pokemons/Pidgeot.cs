using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pidgeot Species to store common natural stats of all Pidgeots
	#region SpeciesPidgeot
	public class SpeciesPidgeot : PokemonSpecies
	{
#nullable enable
		private static SpeciesPidgeot? _instance = null;
#nullable restore
        public static SpeciesPidgeot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPidgeot();
                }
                return _instance;
            }
        }

		#region SpeciesPidgeot Constructor
		public SpeciesPidgeot() : base(
			18,
			"Pidgeot",
			1.5,
			39.5,
			83, // HPs
			80, 75, // Attack & Defense
			70, 70, // Special Attack & Defense
			101		
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
				"Gust",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
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
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Work-Up",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Pidgeot PokemonInstance Class
	#region Pidgeot
	public class PidgeotInstance : PokemonInstance
	{
		#region Pidgeot Constructors
		/// <summary>
		/// Pidgeot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PidgeotInstance(string nickname, int level)
		: base(
				SpeciesPidgeot.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeot Builder only waiting for a Level
		/// </summary>
		public PidgeotInstance(int level)
		: base(
				SpeciesPidgeot.Instance, // PokemonInstance Species
				"Pidgeot", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeot Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PidgeotInstance() : base(
			SpeciesPidgeot.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}