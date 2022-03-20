using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Omastar Species to store common natural stats of all Omastars
	#region OmastarSpecies
	public class OmastarSpecies : PokemonSpecies
	{
#nullable enable
		private static OmastarSpecies? _instance = null;
#nullable restore
        public static OmastarSpecies Instance => _instance ?? (_instance = new OmastarSpecies());

		#region OmastarSpecies Constructor
		public OmastarSpecies() : base(
			139,
			"Omastar",
			Rock.Instance, Water.Instance,
			1.0,
			35.0,
			new PokemonStats(
				70, // HPs
				60, 125, // Attack & Defense
				115, 70, // Spacial Attack & Defense
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
				"Bind",
				"Headbutt",
				"Horn-Attack",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Seismic-Toss",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Spike-Cannon",
				"Constrict",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Tickle",
				"Iron-Defense",
				"Mud-Shot",
				"Rock-Blast",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Rock-Polish",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Scald",
				"Shell-Smash",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}