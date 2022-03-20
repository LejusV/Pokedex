using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Slowbro Species to store common natural stats of all Slowbros
	#region SlowbroSpecies
	public class SlowbroSpecies : PokemonSpecies
	{
#nullable enable
		private static SlowbroSpecies? _instance = null;
#nullable restore
        public static SlowbroSpecies Instance => _instance ?? (_instance = new SlowbroSpecies());

		#region SlowbroSpecies Constructor
		public SlowbroSpecies() : base(
			80,
			"Slowbro",
			Water.Instance, Psychic.Instance,
			1.6,
			78.5,
			new PokemonStats(
				95, // HPs
				75, 110, // Attack & Defense
				100, 80, // Spacial Attack & Defense
				30 // Speed
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
				"Mega-Punch",
				"Pay-Day",
				"Ice-Punch",
				"Mega-Kick",
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
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
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
				"Withdraw",
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
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Yawn",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Slack-Off",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Foul-Play",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Heal-Pulse",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}