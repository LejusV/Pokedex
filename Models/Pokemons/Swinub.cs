using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Swinub Species to store common natural stats of all Swinubs
	#region SpeciesSwinub
	public class SpeciesSwinub : PokemonSpecies
	{
#nullable enable
		private static SpeciesSwinub? _instance = null;
#nullable restore
        public static SpeciesSwinub Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSwinub();
                }
                return _instance;
            }
        }

		#region SpeciesSwinub Constructor
		public SpeciesSwinub() : base(
			220,
			"Swinub",
			0.4,
			6.5,
			50, // HPs
			50, 40, // Attack & Defense
			30, 30, // Special Attack & Defense
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Earthquake",
				"Fissure",
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
				"Flail",
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
				"Icicle-Spear",
				"Mud-Shot",
				"Natural-Gift",
				"Earth-Power",
				"Avalanche",
				"Ice-Shard",
				"Mud-Bomb",
				"Captivate",
				"Stealth-Rock",
				"Round",
				"Bulldoze",
				"Icicle-Crash",
				"Freeze-Dry",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Swinub PokemonInstance Class
	#region Swinub
	public class SwinubInstance : PokemonInstance
	{
		#region Swinub Constructors
		/// <summary>
		/// Swinub Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SwinubInstance(string nickname, int level)
		: base(
				SpeciesSwinub.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swinub Builder only waiting for a Level
		/// </summary>
		public SwinubInstance(int level)
		: base(
				SpeciesSwinub.Instance, // PokemonInstance Species
				"Swinub", level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swinub Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SwinubInstance() : base(
			SpeciesSwinub.Instance, // PokemonInstance Species
			Ice.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}