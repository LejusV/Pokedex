using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rockruff Species to store common natural stats of all Rockruffs
	#region SpeciesRockruff
	public class SpeciesRockruff : PokemonSpecies
	{
#nullable enable
		private static SpeciesRockruff? _instance = null;
#nullable restore
        public static SpeciesRockruff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRockruff();
                }
                return _instance;
            }
        }

		#region SpeciesRockruff Constructor
		public SpeciesRockruff() : base(
			744,
			"Rockruff",
			0.5,
			9.2,
			45, // HPs
			65, 40, // Attack & Defense
			30, 40, // Special Attack & Defense
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
				"Sand-Attack",
				"Tackle",
				"Thrash",
				"Leer",
				"Bite",
				"Roar",
				"Rock-Throw",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Crunch",
				"Facade",
				"Taunt",
				"Crush-Claw",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Howl",
				"Sucker-Punch",
				"Rock-Polish",
				"Thunder-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Stone-Edge",
				"Stealth-Rock",
				"Round",
				"Echoed-Voice",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Rockruff PokemonInstance Class
	#region Rockruff
	public class RockruffInstance : PokemonInstance
	{
		#region Rockruff Constructors
		/// <summary>
		/// Rockruff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RockruffInstance(string nickname, int level)
		: base(
				SpeciesRockruff.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rockruff Builder only waiting for a Level
		/// </summary>
		public RockruffInstance(int level)
		: base(
				SpeciesRockruff.Instance, // PokemonInstance Species
				"Rockruff", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rockruff Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RockruffInstance() : base(
			SpeciesRockruff.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}