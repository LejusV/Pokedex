using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pidove Species to store common natural stats of all Pidoves
	#region SpeciesPidove
	public class SpeciesPidove : PokemonSpecies
	{
#nullable enable
		private static SpeciesPidove? _instance = null;
#nullable restore
        public static SpeciesPidove Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPidove();
                }
                return _instance;
            }
        }

		#region SpeciesPidove Constructor
		public SpeciesPidove() : base(
			"Pidove",
			0.3,
			2.1,
			50, // HPs
			55, 50, // Attack & Defense
			36, 30, // Special Attack & Defense
			43		
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
				"Hypnosis",
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
				"Morning-Sun",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Taunt",
				"Wish",
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Lucky-Chant",
				"Night-Slash",
				"Air-Slash",
				"Round",
				"Echoed-Voice",
				"Bestow",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Pidove PokemonInstance Class
	#region Pidove
	public class PidoveInstance : PokemonInstance
	{
		#region Pidove Constructors
		/// <summary>
		/// Pidove Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PidoveInstance(string nickname, int level)
		: base(
				519,
				SpeciesPidove.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidove Builder only waiting for a Level
		/// </summary>
		public PidoveInstance(int level)
		: base(
				519,
				SpeciesPidove.Instance, // PokemonInstance Species
				"Pidove", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidove Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Pidove() : base(
			519,
			SpeciesPidove.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}