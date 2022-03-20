using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Blissey Species to store common natural stats of all Blisseys
	#region BlisseySpecies
	public class BlisseySpecies : PokemonSpecies
	{
#nullable enable
		private static BlisseySpecies? _instance = null;
#nullable restore
        public static BlisseySpecies Instance => _instance ?? (_instance = new BlisseySpecies());

		#region BlisseySpecies Constructor
		public BlisseySpecies() : base(
			242,
			"Blissey",
			Normal.Instance,
			1.5,
			46.8,
			new PokemonStats(
				255, // HPs
				10, 10, // Attack & Defense
				75, 135, // Spacial Attack & Defense
				55 // Speed
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
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
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
				"Mimic",
				"Double-Team",
				"Minimize",
				"Defense-Curl",
				"Light-Screen",
				"Metronome",
				"Egg-Bomb",
				"Fire-Blast",
				"Soft-Boiled",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
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
				"Rock-Tomb",
				"Block",
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
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
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