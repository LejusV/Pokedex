using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hariyama Species to store common natural stats of all Hariyamas
	#region HariyamaSpecies
	public class HariyamaSpecies : PokemonSpecies
	{
#nullable enable
		private static HariyamaSpecies? _instance = null;
#nullable restore
        public static HariyamaSpecies Instance => _instance ?? (_instance = new HariyamaSpecies());

		#region HariyamaSpecies Constructor
		public HariyamaSpecies() : base(
			297,
			"Hariyama",
			Fighting.Instance,
			2.3,
			253.8,
			new PokemonStats(
				144, // HPs
				120, 60, // Attack & Defense
				40, 60, // Spacial Attack & Defense
				50 // Speed
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
				"Hyper-Beam",
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
				"Belly-Drum",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Vital-Throw",
				"Hidden-Power",
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
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Arm-Thrust",
				"Rock-Tomb",
				"Bulk-Up",
				"Wake-Up-Slap",
				"Brine",
				"Natural-Gift",
				"Close-Combat",
				"Payback",
				"Fling",
				"Force-Palm",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Smack-Down",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
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