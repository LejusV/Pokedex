using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Magnezone Species to store common natural stats of all Magnezones
	#region MagnezoneSpecies
	public class MagnezoneSpecies : PokemonSpecies
	{
#nullable enable
		private static MagnezoneSpecies? _instance = null;
#nullable restore
        public static MagnezoneSpecies Instance => _instance ?? (_instance = new MagnezoneSpecies());

		#region MagnezoneSpecies Constructor
		public MagnezoneSpecies() : base(
			462,
			"Magnezone",
			Electric.Instance, Steel.Instance,
			1.2,
			180.0,
			new PokemonStats(
				70, // HPs
				70, 115, // Attack & Defense
				130, 90, // Spacial Attack & Defense
				60 // Speed
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
				"Supersonic",
				"Sonic-Boom",
				"Hyper-Beam",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Screech",
				"Double-Team",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Flash",
				"Explosion",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Snore",
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
				"Mirror-Coat",
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
				"Iron-Head",
				"Magnet-Bomb",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Confide",
				"Magnetic-Flux",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion
}