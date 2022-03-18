using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tranquill Species to store common natural stats of all Tranquills
	#region SpeciesTranquill
	public class SpeciesTranquill : PokemonSpecies
	{
#nullable enable
		private static SpeciesTranquill? _instance = null;
#nullable restore
        public static SpeciesTranquill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTranquill();
                }
                return _instance;
            }
        }

		#region SpeciesTranquill Constructor
		public SpeciesTranquill() : base(
			520,
			"Tranquill",
			0.6,
			15.0,
			62, // HPs
			77, 62, // Attack & Defense
			50, 42, // Special Attack & Defense
			65		
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
				"Fly",
				"Leer",
				"Growl",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Detect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Tranquill PokemonInstance Class
	#region Tranquill
	public class TranquillInstance : PokemonInstance
	{
		#region Tranquill Constructors
		/// <summary>
		/// Tranquill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TranquillInstance(string nickname, int level)
		: base(
				SpeciesTranquill.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tranquill Builder only waiting for a Level
		/// </summary>
		public TranquillInstance(int level)
		: base(
				SpeciesTranquill.Instance, // PokemonInstance Species
				"Tranquill", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tranquill Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TranquillInstance() : base(
			SpeciesTranquill.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}