using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rhyperior Species to store common natural stats of all Rhyperiors
	#region RhyperiorSpecies
	public class RhyperiorSpecies : PokemonSpecies
	{
#nullable enable
		private static RhyperiorSpecies? _instance = null;
#nullable restore
        public static RhyperiorSpecies Instance => _instance ?? (_instance = new RhyperiorSpecies());

		#region RhyperiorSpecies Constructor
		public RhyperiorSpecies() : base(
			464,
			"Rhyperior",
			Ground.Instance, Rock.Instance,
			2.4,
			282.8,
			new PokemonStats(
				115, // HPs
				140, 130, // Attack & Defense
				55, 55, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Stomp",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Horn-Drill",
				"Take-Down",
				"Tail-Whip",
				"Roar",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
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
				"Flash-Cannon",
				"Rock-Climb",
				"Rock-Wrecker",
				"Iron-Head",
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