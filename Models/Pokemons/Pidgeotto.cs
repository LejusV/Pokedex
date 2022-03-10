using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pidgeotto Species to store common natural stats of all Pidgeottos
	#region SpeciesPidgeotto
	public class SpeciesPidgeotto : PokemonSpecies
	{
#nullable enable
		private static SpeciesPidgeotto? _instance = null;
#nullable restore
        public static SpeciesPidgeotto Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPidgeotto();
                }
                return _instance;
            }
        }

		#region SpeciesPidgeotto Constructor
		public SpeciesPidgeotto() : base(
			"Pidgeotto",
			1.1,
			30.0,
			63, // HPs
			60, 55, // Attack & Defense
			50, 50, // Special Attack & Defense
			71		
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

	//Pidgeotto PokemonInstance Class
	#region Pidgeotto
	public class PidgeottoInstance : PokemonInstance
	{
		#region Pidgeotto Constructors
		/// <summary>
		/// Pidgeotto Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PidgeottoInstance(string nickname, int level)
		: base(
				17,
				SpeciesPidgeotto.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeotto Builder only waiting for a Level
		/// </summary>
		public PidgeottoInstance(int level)
		: base(
				17,
				SpeciesPidgeotto.Instance, // PokemonInstance Species
				"Pidgeotto", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeotto Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Pidgeotto() : base(
			17,
			SpeciesPidgeotto.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}