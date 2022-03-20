using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Relicanth Species to store common natural stats of all Relicanths
	#region RelicanthSpecies
	public class RelicanthSpecies : PokemonSpecies
	{
#nullable enable
		private static RelicanthSpecies? _instance = null;
#nullable restore
        public static RelicanthSpecies Instance => _instance ?? (_instance = new RelicanthSpecies());

		#region RelicanthSpecies Constructor
		public RelicanthSpecies() : base(
			369,
			"Relicanth",
			Water.Instance, Rock.Instance,
			1.0,
			23.4,
			new PokemonStats(
				100, // HPs
				90, 130, // Attack & Defense
				45, 65, // Spacial Attack & Defense
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Waterfall",
				"Skull-Bash",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Magnitude",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Water-Sport",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Rock-Polish",
				"Aqua-Tail",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Smack-Down",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}