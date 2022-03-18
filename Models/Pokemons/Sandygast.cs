using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sandygast Species to store common natural stats of all Sandygasts
	#region SpeciesSandygast
	public class SpeciesSandygast : PokemonSpecies
	{
#nullable enable
		private static SpeciesSandygast? _instance = null;
#nullable restore
        public static SpeciesSandygast Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSandygast();
                }
                return _instance;
            }
        }

		#region SpeciesSandygast Constructor
		public SpeciesSandygast() : base(
			769,
			"Sandygast",
			0.5,
			70.0,
			55, // HPs
			55, 80, // Attack & Defense
			70, 45, // Special Attack & Defense
			15		
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
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Curse",
				"Protect",
				"Destiny-Bond",
				"Sandstorm",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Ancient-Power",
				"Shadow-Ball",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Astonish",
				"Rock-Tomb",
				"Sand-Tomb",
				"Iron-Defense",
				"Rock-Polish",
				"Energy-Ball",
				"Earth-Power",
				"Stone-Edge",
				"Round",
				"Bulldoze",
				"Confide",
				"Infestation",
				"Shore-Up"
			};
		}
		#endregion
	}
	#endregion

	//Sandygast PokemonInstance Class
	#region Sandygast
	public class SandygastInstance : PokemonInstance
	{
		#region Sandygast Constructors
		/// <summary>
		/// Sandygast Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SandygastInstance(string nickname, int level)
		: base(
				SpeciesSandygast.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandygast Builder only waiting for a Level
		/// </summary>
		public SandygastInstance(int level)
		: base(
				SpeciesSandygast.Instance, // PokemonInstance Species
				"Sandygast", level,
				Ghost.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandygast Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SandygastInstance() : base(
			SpeciesSandygast.Instance, // PokemonInstance Species
			Ghost.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}