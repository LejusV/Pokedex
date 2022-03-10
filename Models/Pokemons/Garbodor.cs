using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Garbodor Species to store common natural stats of all Garbodors
	#region SpeciesGarbodor
	public class SpeciesGarbodor : PokemonSpecies
	{
#nullable enable
		private static SpeciesGarbodor? _instance = null;
#nullable restore
        public static SpeciesGarbodor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGarbodor();
                }
                return _instance;
            }
        }

		#region SpeciesGarbodor Constructor
		public SpeciesGarbodor() : base(
			"Garbodor",
			1.9,
			107.3,
			80, // HPs
			95, 82, // Attack & Defense
			60, 82, // Special Attack & Defense
			75		
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
				"Pound",
				"Double-Slap",
				"Body-Slam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Sludge",
				"Amnesia",
				"Poison-Gas",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Stockpile",
				"Swallow",
				"Facade",
				"Recycle",
				"Secret-Power",
				"Payback",
				"Fling",
				"Toxic-Spikes",
				"Rock-Polish",
				"Dark-Pulse",
				"Seed-Bomb",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Gunk-Shot",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Clear-Smog",
				"Belch",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Garbodor PokemonInstance Class
	#region Garbodor
	public class GarbodorInstance : PokemonInstance
	{
		#region Garbodor Constructors
		/// <summary>
		/// Garbodor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GarbodorInstance(string nickname, int level)
		: base(
				569,
				SpeciesGarbodor.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garbodor Builder only waiting for a Level
		/// </summary>
		public GarbodorInstance(int level)
		: base(
				569,
				SpeciesGarbodor.Instance, // PokemonInstance Species
				"Garbodor", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garbodor Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Garbodor() : base(
			569,
			SpeciesGarbodor.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}