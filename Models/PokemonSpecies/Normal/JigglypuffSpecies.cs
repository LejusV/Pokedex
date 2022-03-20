using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Jigglypuff Species to store common natural stats of all Jigglypuffs
	#region JigglypuffSpecies
	public class JigglypuffSpecies : PokemonSpecies
	{
#nullable enable
		private static JigglypuffSpecies? _instance = null;
#nullable restore
        public static JigglypuffSpecies Instance => _instance ?? (_instance = new JigglypuffSpecies());

		#region JigglypuffSpecies Constructor
		public JigglypuffSpecies() : base(
			39,
			"Jigglypuff",
			Normal.Instance, Fairy.Instance,
			0.5,
			5.5,
			new PokemonStats(
				115, // HPs
				45, 20, // Attack & Defense
				45, 25, // Spacial Attack & Defense
				20 // Speed
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
				"Sing",
				"Disable",
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
				"Stockpile",
				"Spit-Up",
				"Swallow",
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
				"Wake-Up-Slap",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Disarming-Voice",
				"Play-Nice",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}