using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Machamp Species to store common natural stats of all Machamps
	#region MachampSpecies
	public class MachampSpecies : PokemonSpecies
	{
#nullable enable
		private static MachampSpecies? _instance = null;
#nullable restore
        public static MachampSpecies Instance => _instance ?? (_instance = new MachampSpecies());

		#region MachampSpecies Constructor
		public MachampSpecies() : base(
			68,
			"Machamp",
			Fighting.Instance,
			1.6,
			130.0,
			new PokemonStats(
				90, // HPs
				130, 80, // Attack & Defense
				65, 85, // Spacial Attack & Defense
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
				"Karate-Chop",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Flamethrower",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Focus-Energy",
				"Bide",
				"Metronome",
				"Fire-Blast",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
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
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Bulk-Up",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Wide-Guard",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}