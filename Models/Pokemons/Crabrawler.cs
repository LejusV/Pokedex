using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Crabrawler Species to store common natural stats of all Crabrawlers
	#region SpeciesCrabrawler
	public class SpeciesCrabrawler : PokemonSpecies
	{
#nullable enable
		private static SpeciesCrabrawler? _instance = null;
#nullable restore
        public static SpeciesCrabrawler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCrabrawler();
                }
                return _instance;
            }
        }

		#region SpeciesCrabrawler Constructor
		public SpeciesCrabrawler() : base(
			"Crabrawler",
			0.6,
			7.0,
			47, // HPs
			82, 57, // Attack & Defense
			42, 47, // Special Attack & Defense
			63		
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
				"Leer",
				"Bubble-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Amnesia",
				"Bubble",
				"Dizzy-Punch",
				"Crabhammer",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Reversal",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Rock-Tomb",
				"Iron-Defense",
				"Bulk-Up",
				"Close-Combat",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Stone-Edge",
				"Wide-Guard",
				"Round",
				"Scald",
				"Bulldoze",
				"Frost-Breath",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Crabrawler PokemonInstance Class
	#region Crabrawler
	public class CrabrawlerInstance : PokemonInstance
	{
		#region Crabrawler Constructors
		/// <summary>
		/// Crabrawler Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CrabrawlerInstance(string nickname, int level)
		: base(
				739,
				SpeciesCrabrawler.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabrawler Builder only waiting for a Level
		/// </summary>
		public CrabrawlerInstance(int level)
		: base(
				739,
				SpeciesCrabrawler.Instance, // PokemonInstance Species
				"Crabrawler", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabrawler Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Crabrawler() : base(
			739,
			SpeciesCrabrawler.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}