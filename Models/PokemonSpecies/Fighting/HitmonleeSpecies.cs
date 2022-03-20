using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hitmonlee Species to store common natural stats of all Hitmonlees
	#region HitmonleeSpecies
	public class HitmonleeSpecies : PokemonSpecies
	{
#nullable enable
		private static HitmonleeSpecies? _instance = null;
#nullable restore
        public static HitmonleeSpecies Instance => _instance ?? (_instance = new HitmonleeSpecies());

		#region HitmonleeSpecies Constructor
		public HitmonleeSpecies() : base(
			106,
			"Hitmonlee",
			Fighting.Instance,
			1.5,
			49.8,
			new PokemonStats(
				50, // HPs
				120, 53, // Attack & Defense
				35, 110, // Spacial Attack & Defense
				87 // Speed
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
				"Double-Kick",
				"Mega-Kick",
				"Jump-Kick",
				"Rolling-Kick",
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
				"Meditate",
				"Rage",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Metronome",
				"Swift",
				"Skull-Bash",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
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
				"Hidden-Power",
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
				"Blaze-Kick",
				"Rock-Tomb",
				"Bulk-Up",
				"Bounce",
				"Covet",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Sucker-Punch",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Wide-Guard",
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