using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Clefairy Species to store common natural stats of all Clefairys
	#region ClefairySpecies
	public class ClefairySpecies : PokemonSpecies
	{
#nullable enable
		private static ClefairySpecies? _instance = null;
#nullable restore
        public static ClefairySpecies Instance => _instance ?? (_instance = new ClefairySpecies());

		#region ClefairySpecies Constructor
		public ClefairySpecies() : base(
			35,
			"Clefairy",
			Fairy.Instance,
			0.6,
			7.5,
			new PokemonStats(
				70, // HPs
				45, 48, // Attack & Defense
				60, 65, // Spacial Attack & Defense
				35 // Speed
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
				"Growl",
				"Sing",
				"Flamethrower",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
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
				"Fire-Blast",
				"Skull-Bash",
				"Soft-Boiled",
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
				"Detect",
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
				"Encore",
				"Iron-Tail",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Follow-Me",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Meteor-Mash",
				"Cosmic-Power",
				"Signal-Beam",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Wake-Up-Slap",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Lucky-Chant",
				"Last-Resort",
				"Drain-Punch",
				"Zen-Headbutt",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Incinerate",
				"Retaliate",
				"Bestow",
				"Work-Up",
				"Disarming-Voice",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion
}