using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hitmonchan Species to store common natural stats of all Hitmonchans
	#region HitmonchanSpecies
	public class HitmonchanSpecies : PokemonSpecies
	{
#nullable enable
		private static HitmonchanSpecies? _instance = null;
#nullable restore
        public static HitmonchanSpecies Instance => _instance ?? (_instance = new HitmonchanSpecies());

		#region HitmonchanSpecies Constructor
		public HitmonchanSpecies() : base(
			107,
			"Hitmonchan",
			Fighting.Instance,
			1.4,
			50.2,
			new PokemonStats(
				50, // HPs
				105, 79, // Attack & Defense
				35, 110, // Spacial Attack & Defense
				76 // Speed
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
				"Comet-Punch",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Metronome",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mach-Punch",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Bullet-Punch",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
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