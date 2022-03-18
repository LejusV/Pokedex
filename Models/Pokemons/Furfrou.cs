using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Furfrou Species to store common natural stats of all Furfrous
	#region SpeciesFurfrou
	public class SpeciesFurfrou : PokemonSpecies
	{
#nullable enable
		private static SpeciesFurfrou? _instance = null;
#nullable restore
        public static SpeciesFurfrou Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFurfrou();
                }
                return _instance;
            }
        }

		#region SpeciesFurfrou Constructor
		public SpeciesFurfrou() : base(
			676,
			"Furfrou",
			1.2,
			28.0,
			75, // HPs
			80, 60, // Attack & Defense
			65, 90, // Special Attack & Defense
			102		
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
				"Tail-Whip",
				"Bite",
				"Growl",
				"Roar",
				"Surf",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Role-Play",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"U-Turn",
				"Last-Resort",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Cotton-Guard",
				"Snarl",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Furfrou PokemonInstance Class
	#region Furfrou
	public class FurfrouInstance : PokemonInstance
	{
		#region Furfrou Constructors
		/// <summary>
		/// Furfrou Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FurfrouInstance(string nickname, int level)
		: base(
				SpeciesFurfrou.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furfrou Builder only waiting for a Level
		/// </summary>
		public FurfrouInstance(int level)
		: base(
				SpeciesFurfrou.Instance, // PokemonInstance Species
				"Furfrou", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furfrou Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public FurfrouInstance() : base(
			SpeciesFurfrou.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}