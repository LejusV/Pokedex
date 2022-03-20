using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Makuhita Species to store common natural stats of all Makuhitas
	#region MakuhitaSpecies
	public class MakuhitaSpecies : PokemonSpecies
	{
#nullable enable
		private static MakuhitaSpecies? _instance = null;
#nullable restore
        public static MakuhitaSpecies Instance => _instance ?? (_instance = new MakuhitaSpecies());

		#region MakuhitaSpecies Constructor
		public MakuhitaSpecies() : base(
			296,
			"Makuhita",
			Fighting.Instance,
			1.0,
			86.4,
			new PokemonStats(
				72, // HPs
				60, 30, // Attack & Defense
				20, 30, // Spacial Attack & Defense
				25 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Whirlwind",
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Surf",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Metronome",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Feint-Attack",
				"Belly-Drum",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Vital-Throw",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Whirlpool",
				"Fake-Out",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Helping-Hand",
				"Role-Play",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Arm-Thrust",
				"Rock-Tomb",
				"Bulk-Up",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Force-Palm",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Bullet-Punch",
				"Rock-Climb",
				"Captivate",
				"Wide-Guard",
				"Smack-Down",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
				"Chip-Away",
				"Retaliate",
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