using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chansey Species to store common natural stats of all Chanseys
	#region ChanseySpecies
	public class ChanseySpecies : PokemonSpecies
	{
#nullable enable
		private static ChanseySpecies? _instance = null;
#nullable restore
        public static ChanseySpecies Instance => _instance ?? (_instance = new ChanseySpecies());

		#region ChanseySpecies Constructor
		public ChanseySpecies() : base(
			113,
			"Chansey",
			Normal.Instance,
			1.1,
			34.6,
			new PokemonStats(
				250, // HPs
				5, 5, // Attack & Defense
				35, 105, // Spacial Attack & Defense
				50 // Speed
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
				"Pound",
				"Double-Slap",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Sing",
				"Flamethrower",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Minimize",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Egg-Bomb",
				"Fire-Blast",
				"Skull-Bash",
				"Soft-Boiled",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
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
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Recycle",
				"Brick-Break",
				"Endeavor",
				"Skill-Swap",
				"Refresh",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Aromatherapy",
				"Rock-Tomb",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Giga-Impact",
				"Mud-Bomb",
				"Zen-Headbutt",
				"Rock-Climb",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Incinerate",
				"Retaliate",
				"Bestow",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}