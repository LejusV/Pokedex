using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Togedemaru Species to store common natural stats of all Togedemarus
	#region TogedemaruSpecies
	public class TogedemaruSpecies : PokemonSpecies
	{
#nullable enable
		private static TogedemaruSpecies? _instance = null;
#nullable restore
        public static TogedemaruSpecies Instance => _instance ?? (_instance = new TogedemaruSpecies());

		#region TogedemaruSpecies Constructor
		public TogedemaruSpecies() : base(
			777,
			"Togedemaru",
			Electric.Instance, Steel.Instance,
			0.3,
			3.3,
			new PokemonStats(
				65, // HPs
				98, 63, // Attack & Defense
				40, 73, // Spacial Attack & Defense
				96 // Speed
			)			
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
}