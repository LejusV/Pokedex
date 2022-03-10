using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pinsir Species to store common natural stats of all Pinsirs
	#region SpeciesPinsir
	public class SpeciesPinsir : PokemonSpecies
	{
#nullable enable
		private static SpeciesPinsir? _instance = null;
#nullable restore
        public static SpeciesPinsir Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPinsir();
                }
                return _instance;
            }
        }

		#region SpeciesPinsir Constructor
		public SpeciesPinsir() : base(
			"Pinsir",
			1.5,
			55.0,
			65, // HPs
			125, 100, // Attack & Defense
			55, 70, // Special Attack & Defense
			85		
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
				"Vice-Grip",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Bind",
				"Headbutt",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Hyper-Beam",
				"Submission",
				"Seismic-Toss",
				"Strength",
				"String-Shot",
				"Earthquake",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Focus-Energy",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Bulk-Up",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Me-First",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Double-Hit",
				"Smack-Down",
				"Storm-Throw",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Pinsir PokemonInstance Class
	#region Pinsir
	public class PinsirInstance : PokemonInstance
	{
		#region Pinsir Constructors
		/// <summary>
		/// Pinsir Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PinsirInstance(string nickname, int level)
		: base(
				127,
				SpeciesPinsir.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pinsir Builder only waiting for a Level
		/// </summary>
		public PinsirInstance(int level)
		: base(
				127,
				SpeciesPinsir.Instance, // PokemonInstance Species
				"Pinsir", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pinsir Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Pinsir() : base(
			127,
			SpeciesPinsir.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}