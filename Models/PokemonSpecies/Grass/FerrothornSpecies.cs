using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ferrothorn Species to store common natural stats of all Ferrothorns
	#region FerrothornSpecies
	public class FerrothornSpecies : PokemonSpecies
	{
#nullable enable
		private static FerrothornSpecies? _instance = null;
#nullable restore
        public static FerrothornSpecies Instance => _instance ?? (_instance = new FerrothornSpecies());

		#region FerrothornSpecies Constructor
		public FerrothornSpecies() : base(
			598,
			"Ferrothorn",
			Grass.Instance, Steel.Instance,
			1.0,
			110.0,
			new PokemonStats(
				74, // HPs
				94, 131, // Attack & Defense
				54, 116, // Spacial Attack & Defense
				20 // Speed
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
				"Swords-Dance",
				"Cut",
				"Tackle",
				"Pin-Missile",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Harden",
				"Self-Destruct",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sandstorm",
				"Giga-Drain",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Gravity",
				"Gyro-Ball",
				"Payback",
				"Worry-Seed",
				"Magnet-Rise",
				"Rock-Polish",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Mirror-Shot",
				"Flash-Cannon",
				"Rock-Climb",
				"Power-Whip",
				"Iron-Head",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}