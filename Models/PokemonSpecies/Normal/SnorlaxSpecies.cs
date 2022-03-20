using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Snorlax Species to store common natural stats of all Snorlaxs
	#region SnorlaxSpecies
	public class SnorlaxSpecies : PokemonSpecies
	{
#nullable enable
		private static SnorlaxSpecies? _instance = null;
#nullable restore
        public static SnorlaxSpecies Instance => _instance ?? (_instance = new SnorlaxSpecies());

		#region SnorlaxSpecies Constructor
		public SnorlaxSpecies() : base(
			143,
			"Snorlax",
			Normal.Instance,
			2.1,
			460.0,
			new PokemonStats(
				160, // HPs
				110, 65, // Attack & Defense
				65, 110, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Whirlwind",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
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
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Psychic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Reflect",
				"Bide",
				"Metronome",
				"Self-Destruct",
				"Lick",
				"Fire-Blast",
				"Skull-Bash",
				"Amnesia",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Recycle",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Block",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Gunk-Shot",
				"Iron-Head",
				"Captivate",
				"Smack-Down",
				"Heavy-Slam",
				"After-You",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Belch",
				"Confide",
				"Power-Up-Punch",
				"High-Horsepower"
			};
		}
		#endregion
	}
	#endregion
}