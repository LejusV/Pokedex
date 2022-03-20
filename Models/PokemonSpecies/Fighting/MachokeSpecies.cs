using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Machoke Species to store common natural stats of all Machokes
	#region MachokeSpecies
	public class MachokeSpecies : PokemonSpecies
	{
#nullable enable
		private static MachokeSpecies? _instance = null;
#nullable restore
        public static MachokeSpecies Instance => _instance ?? (_instance = new MachokeSpecies());

		#region MachokeSpecies Constructor
		public MachokeSpecies() : base(
			67,
			"Machoke",
			Fighting.Instance,
			1.5,
			70.5,
			new PokemonStats(
				80, // HPs
				100, 70, // Attack & Defense
				50, 60, // Spacial Attack & Defense
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
				"Rock-Climb",
				"Captivate",
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