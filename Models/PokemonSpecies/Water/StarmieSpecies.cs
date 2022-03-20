using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Starmie Species to store common natural stats of all Starmies
	#region StarmieSpecies
	public class StarmieSpecies : PokemonSpecies
	{
#nullable enable
		private static StarmieSpecies? _instance = null;
#nullable restore
        public static StarmieSpecies Instance => _instance ?? (_instance = new StarmieSpecies());

		#region StarmieSpecies Constructor
		public StarmieSpecies() : base(
			121,
			"Starmie",
			Water.Instance, Psychic.Instance,
			1.1,
			80.0,
			new PokemonStats(
				60, // HPs
				75, 85, // Attack & Defense
				100, 85, // Spacial Attack & Defense
				115 // Speed
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
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
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
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Nightmare",
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
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Water-Pulse",
				"Gravity",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Giga-Impact",
				"Avalanche",
				"Flash-Cannon",
				"Trick-Room",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Scald",
				"Confide",
				"Dazzling-Gleam",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion
}