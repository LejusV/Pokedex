using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Komala Species to store common natural stats of all Komalas
	#region SpeciesKomala
	public class SpeciesKomala : PokemonSpecies
	{
#nullable enable
		private static SpeciesKomala? _instance = null;
#nullable restore
        public static SpeciesKomala Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKomala();
                }
                return _instance;
            }
        }

		#region SpeciesKomala Constructor
		public SpeciesKomala() : base(
			775,
			"Komala",
			0.4,
			19.9,
			65, // HPs
			115, 65, // Attack & Defense
			75, 95, // Special Attack & Defense
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
				"Swords-Dance",
				"Slam",
				"Thrash",
				"Sing",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Rock-Slide",
				"Substitute",
				"Flail",
				"Protect",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Wish",
				"Brick-Break",
				"Yawn",
				"Bulk-Up",
				"Calm-Mind",
				"U-Turn",
				"Payback",
				"Sucker-Punch",
				"Shadow-Claw",
				"Wood-Hammer",
				"Low-Sweep",
				"Round",
				"Quash",
				"Acrobatics",
				"Bulldoze",
				"Work-Up",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Komala PokemonInstance Class
	#region Komala
	public class KomalaInstance : PokemonInstance
	{
		#region Komala Constructors
		/// <summary>
		/// Komala Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KomalaInstance(string nickname, int level)
		: base(
				SpeciesKomala.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Komala Builder only waiting for a Level
		/// </summary>
		public KomalaInstance(int level)
		: base(
				SpeciesKomala.Instance, // PokemonInstance Species
				"Komala", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Komala Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KomalaInstance() : base(
			SpeciesKomala.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}