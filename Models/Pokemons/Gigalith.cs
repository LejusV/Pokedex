using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gigalith Species to store common natural stats of all Gigaliths
	#region SpeciesGigalith
	public class SpeciesGigalith : PokemonSpecies
	{
#nullable enable
		private static SpeciesGigalith? _instance = null;
#nullable restore
        public static SpeciesGigalith Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGigalith();
                }
                return _instance;
            }
        }

		#region SpeciesGigalith Constructor
		public SpeciesGigalith() : base(
			526,
			"Gigalith",
			1.7,
			260.0,
			85, // HPs
			135, 130, // Attack & Defense
			60, 80, // Special Attack & Defense
			25		
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
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
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
				"Superpower",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Gravity",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Giga-Impact",
				"Flash-Cannon",
				"Iron-Head",
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

	//Gigalith PokemonInstance Class
	#region Gigalith
	public class GigalithInstance : PokemonInstance
	{
		#region Gigalith Constructors
		/// <summary>
		/// Gigalith Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GigalithInstance(string nickname, int level)
		: base(
				SpeciesGigalith.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gigalith Builder only waiting for a Level
		/// </summary>
		public GigalithInstance(int level)
		: base(
				SpeciesGigalith.Instance, // PokemonInstance Species
				"Gigalith", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gigalith Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GigalithInstance() : base(
			SpeciesGigalith.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}