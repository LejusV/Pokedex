using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Blitzle Species to store common natural stats of all Blitzles
	#region SpeciesBlitzle
	public class SpeciesBlitzle : PokemonSpecies
	{
#nullable enable
		private static SpeciesBlitzle? _instance = null;
#nullable restore
        public static SpeciesBlitzle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBlitzle();
                }
                return _instance;
            }
        }

		#region SpeciesBlitzle Constructor
		public SpeciesBlitzle() : base(
			"Blitzle",
			0.8,
			29.8,
			45, // HPs
			60, 32, // Attack & Defense
			50, 32, // Special Attack & Defense
			76		
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
				"Stomp",
				"Double-Kick",
				"Sand-Attack",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Charge",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"Feint",
				"Me-First",
				"Magnet-Rise",
				"Discharge",
				"Charge-Beam",
				"Flame-Charge",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Blitzle PokemonInstance Class
	#region Blitzle
	public class BlitzleInstance : PokemonInstance
	{
		#region Blitzle Constructors
		/// <summary>
		/// Blitzle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BlitzleInstance(string nickname, int level)
		: base(
				522,
				SpeciesBlitzle.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blitzle Builder only waiting for a Level
		/// </summary>
		public BlitzleInstance(int level)
		: base(
				522,
				SpeciesBlitzle.Instance, // PokemonInstance Species
				"Blitzle", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blitzle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Blitzle() : base(
			522,
			SpeciesBlitzle.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}