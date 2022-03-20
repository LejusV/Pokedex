using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wigglytuff Species to store common natural stats of all Wigglytuffs
	#region WigglytuffSpecies
	public class WigglytuffSpecies : PokemonSpecies
	{
#nullable enable
		private static WigglytuffSpecies? _instance = null;
#nullable restore
        public static WigglytuffSpecies Instance => _instance ?? (_instance = new WigglytuffSpecies());

		#region WigglytuffSpecies Constructor
		public WigglytuffSpecies() : base(
			40,
			"Wigglytuff",
			Normal.Instance, Fairy.Instance,
			1.0,
			12.0,
			new PokemonStats(
				140, // HPs
				70, 45, // Attack & Defense
				85, 50, // Spacial Attack & Defense
				45 // Speed
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
				"Disable",
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
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
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
				"Pain-Split",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Play-Rough",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}