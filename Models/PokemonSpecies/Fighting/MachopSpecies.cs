using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Machop Species to store common natural stats of all Machops
	#region MachopSpecies
	public class MachopSpecies : PokemonSpecies
	{
#nullable enable
		private static MachopSpecies? _instance = null;
#nullable restore
        public static MachopSpecies Instance => _instance ?? (_instance = new MachopSpecies());

		#region MachopSpecies Constructor
		public MachopSpecies() : base(
			66,
			"Machop",
			Fighting.Instance,
			0.8,
			19.5,
			new PokemonStats(
				70, // HPs
				80, 50, // Attack & Defense
				35, 35, // Spacial Attack & Defense
				35 // Speed
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
				"Rolling-Kick",
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
				"Meditate",
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
				"Encore",
				"Vital-Throw",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
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
				"Rock-Tomb",
				"Tickle",
				"Bulk-Up",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Close-Combat",
				"Payback",
				"Fling",
				"Power-Trick",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Bullet-Punch",
				"Rock-Climb",
				"Captivate",
				"Smack-Down",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
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