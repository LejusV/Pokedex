using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Palossand Species to store common natural stats of all Palossands
	#region SpeciesPalossand
	public class SpeciesPalossand : PokemonSpecies
	{
#nullable enable
		private static SpeciesPalossand? _instance = null;
#nullable restore
        public static SpeciesPalossand Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPalossand();
                }
                return _instance;
            }
        }

		#region SpeciesPalossand Constructor
		public SpeciesPalossand() : base(
			770,
			"Palossand",
			1.3,
			250.0,
			85, // HPs
			75, 110, // Attack & Defense
			100, 75, // Special Attack & Defense
			35		
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
				"Absorb",
				"Mega-Drain",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Harden",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Sandstorm",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Shadow-Ball",
				"Facade",
				"Astonish",
				"Rock-Tomb",
				"Sand-Tomb",
				"Iron-Defense",
				"Embargo",
				"Fling",
				"Rock-Polish",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Stone-Edge",
				"Round",
				"Quash",
				"Bulldoze",
				"Confide",
				"Infestation",
				"Shore-Up"
			};
		}
		#endregion
	}
	#endregion

	//Palossand PokemonInstance Class
	#region Palossand
	public class PalossandInstance : PokemonInstance
	{
		#region Palossand Constructors
		/// <summary>
		/// Palossand Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PalossandInstance(string nickname, int level)
		: base(
				SpeciesPalossand.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palossand Builder only waiting for a Level
		/// </summary>
		public PalossandInstance(int level)
		: base(
				SpeciesPalossand.Instance, // PokemonInstance Species
				"Palossand", level,
				Ghost.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palossand Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PalossandInstance() : base(
			SpeciesPalossand.Instance, // PokemonInstance Species
			Ghost.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}