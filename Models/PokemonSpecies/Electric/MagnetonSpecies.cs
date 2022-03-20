using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Magneton Species to store common natural stats of all Magnetons
	#region MagnetonSpecies
	public class MagnetonSpecies : PokemonSpecies
	{
#nullable enable
		private static MagnetonSpecies? _instance = null;
#nullable restore
        public static MagnetonSpecies Instance => _instance ?? (_instance = new MagnetonSpecies());

		#region MagnetonSpecies Constructor
		public MagnetonSpecies() : base(
			82,
			"Magneton",
			Electric.Instance, Steel.Instance,
			1.0,
			60.0,
			new PokemonStats(
				50, // HPs
				60, 95, // Attack & Defense
				120, 70, // Spacial Attack & Defense
				70 // Speed
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
				"Hyper-Beam",
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
				"Tri-Attack",
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
				"Giga-Impact",
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
				"Confide",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion
}