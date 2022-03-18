using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Piloswine Species to store common natural stats of all Piloswines
	#region SpeciesPiloswine
	public class SpeciesPiloswine : PokemonSpecies
	{
#nullable enable
		private static SpeciesPiloswine? _instance = null;
#nullable restore
        public static SpeciesPiloswine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPiloswine();
                }
                return _instance;
            }
        }

		#region SpeciesPiloswine Constructor
		public SpeciesPiloswine() : base(
			221,
			"Piloswine",
			1.1,
			55.8,
			100, // HPs
			100, 80, // Attack & Defense
			60, 60, // Special Attack & Defense
			50		
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
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Roar",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Peck",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Mud-Sport",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Natural-Gift",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Mud-Bomb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Piloswine PokemonInstance Class
	#region Piloswine
	public class PiloswineInstance : PokemonInstance
	{
		#region Piloswine Constructors
		/// <summary>
		/// Piloswine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PiloswineInstance(string nickname, int level)
		: base(
				SpeciesPiloswine.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piloswine Builder only waiting for a Level
		/// </summary>
		public PiloswineInstance(int level)
		: base(
				SpeciesPiloswine.Instance, // PokemonInstance Species
				"Piloswine", level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piloswine Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PiloswineInstance() : base(
			SpeciesPiloswine.Instance, // PokemonInstance Species
			Ice.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}