using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nidoking Species to store common natural stats of all Nidokings
	#region NidokingSpecies
	public class NidokingSpecies : PokemonSpecies
	{
#nullable enable
		private static NidokingSpecies? _instance = null;
#nullable restore
        public static NidokingSpecies Instance => _instance ?? (_instance = new NidokingSpecies());

		#region NidokingSpecies Constructor
		public NidokingSpecies() : base(
			34,
			"Nidoking",
			Poison.Instance, Ground.Instance,
			1.4,
			62.0,
			new PokemonStats(
				81, // HPs
				102, 77, // Attack & Defense
				85, 75, // Spacial Attack & Defense
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
				"Mega-Punch",
				"Pay-Day",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Double-Kick",
				"Mega-Kick",
				"Headbutt",
				"Horn-Attack",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Poison-Sting",
				"Roar",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Peck",
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
				"Defense-Curl",
				"Reflect",
				"Focus-Energy",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Outrage",
				"Sandstorm",
				"Endure",
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
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Sucker-Punch",
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
				"Hone-Claws",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Chip-Away",
				"Incinerate",
				"Quash",
				"Bulldoze",
				"Dragon-Tail",
				"Drill-Run",
				"Confide",
				"Power-Up-Punch",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}