using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Stufful Species to store common natural stats of all Stuffuls
	#region SpeciesStufful
	public class SpeciesStufful : PokemonSpecies
	{
#nullable enable
		private static SpeciesStufful? _instance = null;
#nullable restore
        public static SpeciesStufful Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStufful();
                }
                return _instance;
            }
        }

		#region SpeciesStufful Constructor
		public SpeciesStufful() : base(
			"Stufful",
			0.5,
			6.8,
			70, // HPs
			75, 50, // Attack & Defense
			45, 50, // Special Attack & Defense
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
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Mega-Kick",
				"Tackle",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Roar",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flail",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Facade",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Hammer-Arm",
				"Payback",
				"Fling",
				"Force-Palm",
				"Focus-Blast",
				"Wide-Guard",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes",
				"Brutal-Swing",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion

	//Stufful PokemonInstance Class
	#region Stufful
	public class StuffulInstance : PokemonInstance
	{
		#region Stufful Constructors
		/// <summary>
		/// Stufful Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StuffulInstance(string nickname, int level)
		: base(
				759,
				SpeciesStufful.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stufful Builder only waiting for a Level
		/// </summary>
		public StuffulInstance(int level)
		: base(
				759,
				SpeciesStufful.Instance, // PokemonInstance Species
				"Stufful", level,
				Normal.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stufful Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Stufful() : base(
			759,
			SpeciesStufful.Instance, // PokemonInstance Species
			Normal.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}