using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Roggenrola Species to store common natural stats of all Roggenrolas
	#region SpeciesRoggenrola
	public class SpeciesRoggenrola : PokemonSpecies
	{
#nullable enable
		private static SpeciesRoggenrola? _instance = null;
#nullable restore
        public static SpeciesRoggenrola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRoggenrola();
                }
                return _instance;
            }
        }

		#region SpeciesRoggenrola Constructor
		public SpeciesRoggenrola() : base(
			"Roggenrola",
			0.4,
			18.0,
			55, // HPs
			75, 85, // Attack & Defense
			25, 25, // Special Attack & Defense
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
				"Headbutt",
				"Tackle",
				"Take-Down",
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
				"Curse",
				"Protect",
				"Mud-Slap",
				"Lock-On",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
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
				"Earth-Power",
				"Flash-Cannon",
				"Stone-Edge",
				"Stealth-Rock",
				"Wide-Guard",
				"Autotomize",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Roggenrola PokemonInstance Class
	#region Roggenrola
	public class RoggenrolaInstance : PokemonInstance
	{
		#region Roggenrola Constructors
		/// <summary>
		/// Roggenrola Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RoggenrolaInstance(string nickname, int level)
		: base(
				524,
				SpeciesRoggenrola.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roggenrola Builder only waiting for a Level
		/// </summary>
		public RoggenrolaInstance(int level)
		: base(
				524,
				SpeciesRoggenrola.Instance, // PokemonInstance Species
				"Roggenrola", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roggenrola Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Roggenrola() : base(
			524,
			SpeciesRoggenrola.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}