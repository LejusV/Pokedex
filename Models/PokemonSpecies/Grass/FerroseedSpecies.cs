using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ferroseed Species to store common natural stats of all Ferroseeds
	#region FerroseedSpecies
	public class FerroseedSpecies : PokemonSpecies
	{
#nullable enable
		private static FerroseedSpecies? _instance = null;
#nullable restore
        public static FerroseedSpecies Instance => _instance ?? (_instance = new FerroseedSpecies());

		#region FerroseedSpecies Constructor
		public FerroseedSpecies() : base(
			597,
			"Ferroseed",
			Grass.Instance, Steel.Instance,
			0.6,
			18.8,
			new PokemonStats(
				44, // HPs
				50, 91, // Attack & Defense
				24, 86, // Spacial Attack & Defense
				10 // Speed
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
				"Pin-Missile",
				"Leech-Seed",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
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
				"Spikes",
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
				"Bullet-Seed",
				"Iron-Defense",
				"Gravity",
				"Gyro-Ball",
				"Payback",
				"Worry-Seed",
				"Magnet-Rise",
				"Rock-Polish",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Mirror-Shot",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stealth-Rock",
				"Hone-Claws",
				"Acid-Spray",
				"Round",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}