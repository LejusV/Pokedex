using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Slowpoke Species to store common natural stats of all Slowpokes
	#region SlowpokeSpecies
	public class SlowpokeSpecies : PokemonSpecies
	{
#nullable enable
		private static SlowpokeSpecies? _instance = null;
#nullable restore
        public static SlowpokeSpecies Instance => _instance ?? (_instance = new SlowpokeSpecies());

		#region SlowpokeSpecies Constructor
		public SlowpokeSpecies() : base(
			79,
			"Slowpoke",
			Water.Instance, Psychic.Instance,
			1.2,
			36.0,
			new PokemonStats(
				90, // HPs
				65, 65, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				15 // Speed
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
				"Pay-Day",
				"Stomp",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Disable",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Strength",
				"Thunder-Wave",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Amnesia",
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
				"Belly-Drum",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Whirlpool",
				"Hail",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Yawn",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Slack-Off",
				"Signal-Beam",
				"Block",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Me-First",
				"Aqua-Tail",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Heal-Pulse",
				"Incinerate",
				"Bulldoze",
				"Belch",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}