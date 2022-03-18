using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Boldore Species to store common natural stats of all Boldores
	#region SpeciesBoldore
	public class SpeciesBoldore : PokemonSpecies
	{
#nullable enable
		private static SpeciesBoldore? _instance = null;
#nullable restore
        public static SpeciesBoldore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBoldore();
                }
                return _instance;
            }
        }

		#region SpeciesBoldore Constructor
		public SpeciesBoldore() : base(
			525,
			"Boldore",
			0.9,
			102.0,
			70, // HPs
			105, 105, // Attack & Defense
			50, 40, // Special Attack & Defense
			20		
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
				"Headbutt",
				"Tackle",
				"Strength",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Harden",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Gravity",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Flash-Cannon",
				"Stone-Edge",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Boldore PokemonInstance Class
	#region Boldore
	public class BoldoreInstance : PokemonInstance
	{
		#region Boldore Constructors
		/// <summary>
		/// Boldore Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BoldoreInstance(string nickname, int level)
		: base(
				SpeciesBoldore.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boldore Builder only waiting for a Level
		/// </summary>
		public BoldoreInstance(int level)
		: base(
				SpeciesBoldore.Instance, // PokemonInstance Species
				"Boldore", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boldore Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BoldoreInstance() : base(
			SpeciesBoldore.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}