using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Poliwrath Species to store common natural stats of all Poliwraths
	#region PoliwrathSpecies
	public class PoliwrathSpecies : PokemonSpecies
	{
#nullable enable
		private static PoliwrathSpecies? _instance = null;
#nullable restore
        public static PoliwrathSpecies Instance => _instance ?? (_instance = new PoliwrathSpecies());

		#region PoliwrathSpecies Constructor
		public PoliwrathSpecies() : base(
			62,
			"Poliwrath",
			Water.Instance, Fighting.Instance,
			1.3,
			54.0,
			new PokemonStats(
				90, // HPs
				95, 95, // Attack & Defense
				70, 90, // Spacial Attack & Defense
				70 // Speed
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
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
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
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Metronome",
				"Waterfall",
				"Skull-Bash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Bulk-Up",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Captivate",
				"Low-Sweep",
				"Round",
				"Scald",
				"Circle-Throw",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}