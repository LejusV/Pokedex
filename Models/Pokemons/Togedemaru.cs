using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Togedemaru Species to store common natural stats of all Togedemarus
	#region SpeciesTogedemaru
	public class SpeciesTogedemaru : PokemonSpecies
	{
#nullable enable
		private static SpeciesTogedemaru? _instance = null;
#nullable restore
        public static SpeciesTogedemaru Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTogedemaru();
                }
                return _instance;
            }
        }

		#region SpeciesTogedemaru Constructor
		public SpeciesTogedemaru() : base(
			"Togedemaru",
			0.3,
			3.3,
			65, // HPs
			98, 63, // Attack & Defense
			40, 73, // Special Attack & Defense
			96		
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
				"Tackle",
				"Twineedle",
				"Pin-Missile",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Rest",
				"Substitute",
				"Thief",
				"Flail",
				"Reversal",
				"Protect",
				"Rollout",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Present",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Fake-Out",
				"Facade",
				"Charge",
				"Wish",
				"Tickle",
				"Gyro-Ball",
				"U-Turn",
				"Payback",
				"Fling",
				"Magnet-Rise",
				"Poison-Jab",
				"Giga-Impact",
				"Discharge",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Volt-Switch",
				"Work-Up",
				"Wild-Charge",
				"Fell-Stinger",
				"Disarming-Voice",
				"Confide",
				"Spiky-Shield",
				"Electric-Terrain",
				"Nuzzle",
				"Zing-Zap"
			};
		}
		#endregion
	}
	#endregion

	//Togedemaru PokemonInstance Class
	#region Togedemaru
	public class TogedemaruInstance : PokemonInstance
	{
		#region Togedemaru Constructors
		/// <summary>
		/// Togedemaru Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TogedemaruInstance(string nickname, int level)
		: base(
				777,
				SpeciesTogedemaru.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togedemaru Builder only waiting for a Level
		/// </summary>
		public TogedemaruInstance(int level)
		: base(
				777,
				SpeciesTogedemaru.Instance, // PokemonInstance Species
				"Togedemaru", level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togedemaru Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Togedemaru() : base(
			777,
			SpeciesTogedemaru.Instance, // PokemonInstance Species
			Electric.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}