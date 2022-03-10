using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Koko Species to store common natural stats of all Tapu-Kokos
	#region SpeciesTapu-Koko
	public class SpeciesTapuKoko : PokemonSpecies
	{
#nullable enable
		private static SpeciesTapuKoko? _instance = null;
#nullable restore
        public static SpeciesTapuKoko Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTapuKoko();
                }
                return _instance;
            }
        }

		#region SpeciesTapu-Koko Constructor
		public SpeciesTapuKoko() : base(
			"Tapu-Koko",
			1.8,
			20.5,
			70, // HPs
			115, 85, // Attack & Defense
			95, 75, // Special Attack & Defense
			130		
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
				"Fly",
				"Roar",
				"Hyper-Beam",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Mirror-Move",
				"Substitute",
				"Thief",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Spark",
				"Steel-Wing",
				"Mean-Look",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Torment",
				"Facade",
				"Nature-Power",
				"Charge",
				"Taunt",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Roost",
				"U-Turn",
				"Power-Swap",
				"Brave-Bird",
				"Giga-Impact",
				"Discharge",
				"Grass-Knot",
				"Electro-Ball",
				"Round",
				"Echoed-Voice",
				"Sky-Drop",
				"Acrobatics",
				"Volt-Switch",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Electric-Terrain",
				"Dazzling-Gleam",
				"Natures-Madness"
			};
		}
		#endregion
	}
	#endregion

	//Tapu-Koko PokemonInstance Class
	#region Tapu-Koko
	public class TapuKokoInstance : PokemonInstance
	{
		#region Tapu-Koko Constructors
		/// <summary>
		/// Tapu-Koko Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TapuKokoInstance(string nickname, int level)
		: base(
				785,
				SpeciesTapuKoko.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Koko Builder only waiting for a Level
		/// </summary>
		public TapuKokoInstance(int level)
		: base(
				785,
				SpeciesTapuKoko.Instance, // PokemonInstance Species
				"Tapu-Koko", level,
				Electric.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Koko Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TapuKoko() : base(
			785,
			SpeciesTapuKoko.Instance, // PokemonInstance Species
			Electric.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}