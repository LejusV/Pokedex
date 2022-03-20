using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Magnemite Species to store common natural stats of all Magnemites
	#region MagnemiteSpecies
	public class MagnemiteSpecies : PokemonSpecies
	{
#nullable enable
		private static MagnemiteSpecies? _instance = null;
#nullable restore
        public static MagnemiteSpecies Instance => _instance ?? (_instance = new MagnemiteSpecies());

		#region MagnemiteSpecies Constructor
		public MagnemiteSpecies() : base(
			81,
			"Magnemite",
			Electric.Instance, Steel.Instance,
			0.3,
			6.0,
			new PokemonStats(
				25, // HPs
				35, 70, // Attack & Defense
				95, 55, // Spacial Attack & Defense
				45 // Speed
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
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Sonic-Boom",
				"Thunder-Shock",
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
				"Swift",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Lock-On",
				"Endure",
				"Rollout",
				"Swagger",
				"Spark",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Metal-Sound",
				"Signal-Beam",
				"Iron-Defense",
				"Shock-Wave",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Magnet-Rise",
				"Mirror-Shot",
				"Flash-Cannon",
				"Discharge",
				"Magnet-Bomb",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}