using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Clefable Species to store common natural stats of all Clefables
	#region ClefableSpecies
	public class ClefableSpecies : PokemonSpecies
	{
#nullable enable
		private static ClefableSpecies? _instance = null;
#nullable restore
        public static ClefableSpecies Instance => _instance ?? (_instance = new ClefableSpecies());

		#region ClefableSpecies Constructor
		public ClefableSpecies() : base(
			36,
			"Clefable",
			Fairy.Instance,
			1.3,
			40.0,
			new PokemonStats(
				95, // HPs
				70, 73, // Attack & Defense
				95, 90, // Spacial Attack & Defense
				60 // Speed
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
				"Signal-Beam",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
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
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Disarming-Voice",
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