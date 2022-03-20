using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Voltorb Species to store common natural stats of all Voltorbs
	#region VoltorbSpecies
	public class VoltorbSpecies : PokemonSpecies
	{
#nullable enable
		private static VoltorbSpecies? _instance = null;
#nullable restore
        public static VoltorbSpecies Instance => _instance ?? (_instance = new VoltorbSpecies());

		#region VoltorbSpecies Constructor
		public VoltorbSpecies() : base(
			100,
			"Voltorb",
			Electric.Instance,
			0.5,
			10.4,
			new PokemonStats(
				40, // HPs
				30, 50, // Attack & Defense
				55, 55, // Spacial Attack & Defense
				100 // Speed
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
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Sonic-Boom",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Rage",
				"Teleport",
				"Mimic",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Swift",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Endure",
				"Rollout",
				"Swagger",
				"Spark",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Torment",
				"Facade",
				"Charge",
				"Taunt",
				"Magic-Coat",
				"Secret-Power",
				"Signal-Beam",
				"Shock-Wave",
				"Gyro-Ball",
				"Natural-Gift",
				"Sucker-Punch",
				"Magnet-Rise",
				"Discharge",
				"Charge-Beam",
				"Electro-Ball",
				"Foul-Play",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Confide",
				"Eerie-Impulse"
			};
		}
		#endregion
	}
	#endregion
}