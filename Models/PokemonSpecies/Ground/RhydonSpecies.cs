using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rhydon Species to store common natural stats of all Rhydons
	#region RhydonSpecies
	public class RhydonSpecies : PokemonSpecies
	{
#nullable enable
		private static RhydonSpecies? _instance = null;
#nullable restore
        public static RhydonSpecies Instance => _instance ?? (_instance = new RhydonSpecies());

		#region RhydonSpecies Constructor
		public RhydonSpecies() : base(
			112,
			"Rhydon",
			Ground.Instance, Rock.Instance,
			1.9,
			120.0,
			new PokemonStats(
				105, // HPs
				130, 120, // Attack & Defense
				45, 45, // Spacial Attack & Defense
				40 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Roar",
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
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Megahorn",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Rock-Blast",
				"Shock-Wave",
				"Hammer-Arm",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Rock-Polish",
				"Poison-Jab",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Drill-Run",
				"Confide",
				"Power-Up-Punch",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}