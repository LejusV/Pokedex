using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lycanroc-Midday Species to store common natural stats of all Lycanroc-Middays
	#region SpeciesLycanroc-Midday
	public class SpeciesLycanrocMidday : PokemonSpecies
	{
#nullable enable
		private static SpeciesLycanrocMidday? _instance = null;
#nullable restore
        public static SpeciesLycanrocMidday Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLycanrocMidday();
                }
                return _instance;
            }
        }

		#region SpeciesLycanroc-Midday Constructor
		public SpeciesLycanrocMidday() : base(
			"Lycanroc-Midday",
			0.8,
			25.0,
			75, // HPs
			115, 65, // Attack & Defense
			55, 65, // Special Attack & Defense
			112		
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
				"Swords-Dance",
				"Sand-Attack",
				"Tackle",
				"Leer",
				"Bite",
				"Roar",
				"Rock-Throw",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Crunch",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Howl",
				"Bulk-Up",
				"Rock-Polish",
				"Rock-Climb",
				"Stone-Edge",
				"Stealth-Rock",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Snarl",
				"Confide",
				"Accelerock"
			};
		}
		#endregion
	}
	#endregion

	//Lycanroc-Midday PokemonInstance Class
	#region Lycanroc-Midday
	public class LycanrocMiddayInstance : PokemonInstance
	{
		#region Lycanroc-Midday Constructors
		/// <summary>
		/// Lycanroc-Midday Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LycanrocMiddayInstance(string nickname, int level)
		: base(
				745,
				SpeciesLycanrocMidday.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lycanroc-Midday Builder only waiting for a Level
		/// </summary>
		public LycanrocMiddayInstance(int level)
		: base(
				745,
				SpeciesLycanrocMidday.Instance, // PokemonInstance Species
				"Lycanroc-Midday", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lycanroc-Midday Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LycanrocMidday() : base(
			745,
			SpeciesLycanrocMidday.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}