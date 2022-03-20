using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Staryu Species to store common natural stats of all Staryus
	#region StaryuSpecies
	public class StaryuSpecies : PokemonSpecies
	{
#nullable enable
		private static StaryuSpecies? _instance = null;
#nullable restore
        public static StaryuSpecies Instance => _instance ?? (_instance = new StaryuSpecies());

		#region StaryuSpecies Constructor
		public StaryuSpecies() : base(
			120,
			"Staryu",
			Water.Instance,
			0.8,
			34.5,
			new PokemonStats(
				30, // HPs
				45, 55, // Attack & Defense
				70, 55, // Spacial Attack & Defense
				85 // Speed
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
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Recover",
				"Harden",
				"Minimize",
				"Confuse-Ray",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Psywave",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Rapid-Spin",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Psych-Up",
				"Whirlpool",
				"Hail",
				"Facade",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Dive",
				"Camouflage",
				"Cosmic-Power",
				"Signal-Beam",
				"Water-Pulse",
				"Gravity",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Power-Gem",
				"Flash-Cannon",
				"Round",
				"Scald",
				"Reflect-Type",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}