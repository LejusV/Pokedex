using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Electrode Species to store common natural stats of all Electrodes
	#region ElectrodeSpecies
	public class ElectrodeSpecies : PokemonSpecies
	{
#nullable enable
		private static ElectrodeSpecies? _instance = null;
#nullable restore
        public static ElectrodeSpecies Instance => _instance ?? (_instance = new ElectrodeSpecies());

		#region ElectrodeSpecies Constructor
		public ElectrodeSpecies() : base(
			101,
			"Electrode",
			Electric.Instance,
			1.2,
			66.6,
			new PokemonStats(
				60, // HPs
				50, 70, // Attack & Defense
				80, 80, // Spacial Attack & Defense
				150 // Speed
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
				"Hyper-Beam",
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
				"Skull-Bash",
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
				"Giga-Impact",
				"Discharge",
				"Charge-Beam",
				"Electro-Ball",
				"Foul-Play",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Confide",
				"Eerie-Impulse",
				"Magnetic-Flux"
			};
		}
		#endregion
	}
	#endregion
}