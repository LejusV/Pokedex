using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nosepass Species to store common natural stats of all Nosepasss
	#region NosepassSpecies
	public class NosepassSpecies : PokemonSpecies
	{
#nullable enable
		private static NosepassSpecies? _instance = null;
#nullable restore
        public static NosepassSpecies Instance => _instance ?? (_instance = new NosepassSpecies());

		#region NosepassSpecies Constructor
		public NosepassSpecies() : base(
			299,
			"Nosepass",
			Rock.Instance,
			1.0,
			97.0,
			new PokemonStats(
				30, // HPs
				45, 135, // Attack & Defense
				45, 90, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Self-Destruct",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Lock-On",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Magnitude",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Magic-Coat",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Magnet-Rise",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Discharge",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Volt-Switch",
				"Bulldoze",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}