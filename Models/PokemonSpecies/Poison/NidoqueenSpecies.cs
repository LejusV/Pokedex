using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nidoqueen Species to store common natural stats of all Nidoqueens
	#region NidoqueenSpecies
	public class NidoqueenSpecies : PokemonSpecies
	{
#nullable enable
		private static NidoqueenSpecies? _instance = null;
#nullable restore
        public static NidoqueenSpecies Instance => _instance ?? (_instance = new NidoqueenSpecies());

		#region NidoqueenSpecies Constructor
		public NidoqueenSpecies() : base(
			31,
			"Nidoqueen",
			Poison.Instance, Ground.Instance,
			1.3,
			60.0,
			new PokemonStats(
				90, // HPs
				92, 87, // Attack & Defense
				75, 85, // Spacial Attack & Defense
				76 // Speed
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
				"Scratch",
				"Cut",
				"Double-Kick",
				"Mega-Kick",
				"Headbutt",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Poison-Sting",
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
				"Defense-Curl",
				"Reflect",
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
				"Aerial-Ace",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
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
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}