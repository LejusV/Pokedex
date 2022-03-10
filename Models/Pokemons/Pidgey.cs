using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pidgey Species to store common natural stats of all Pidgeys
	#region SpeciesPidgey
	public class SpeciesPidgey : PokemonSpecies
	{
#nullable enable
		private static SpeciesPidgey? _instance = null;
#nullable restore
        public static SpeciesPidgey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPidgey();
                }
                return _instance;
            }
        }

		#region SpeciesPidgey Constructor
		public SpeciesPidgey() : base(
			"Pidgey",
			0.3,
			1.8,
			40, // HPs
			45, 40, // Attack & Defense
			35, 35, // Special Attack & Defense
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
				"Razor-Wind",
				"Gust",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Double-Edge",
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
				"Feint-Attack",
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
				"Brave-Bird",
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

	//Pidgey PokemonInstance Class
	#region Pidgey
	public class PidgeyInstance : PokemonInstance
	{
		#region Pidgey Constructors
		/// <summary>
		/// Pidgey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PidgeyInstance(string nickname, int level)
		: base(
				16,
				SpeciesPidgey.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgey Builder only waiting for a Level
		/// </summary>
		public PidgeyInstance(int level)
		: base(
				16,
				SpeciesPidgey.Instance, // PokemonInstance Species
				"Pidgey", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgey Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Pidgey() : base(
			16,
			SpeciesPidgey.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}