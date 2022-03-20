using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mankey Species to store common natural stats of all Mankeys
	#region MankeySpecies
	public class MankeySpecies : PokemonSpecies
	{
#nullable enable
		private static MankeySpecies? _instance = null;
#nullable restore
        public static MankeySpecies Instance => _instance ?? (_instance = new MankeySpecies());

		#region MankeySpecies Constructor
		public MankeySpecies() : base(
			56,
			"Mankey",
			Fighting.Instance,
			0.5,
			28.0,
			new PokemonStats(
				40, // HPs
				80, 35, // Attack & Defense
				35, 45, // Spacial Attack & Defense
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
				"Karate-Chop",
				"Mega-Punch",
				"Pay-Day",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Meditate",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Bide",
				"Metronome",
				"Swift",
				"Skull-Bash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Encore",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Beat-Up",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"U-Turn",
				"Close-Combat",
				"Payback",
				"Assurance",
				"Fling",
				"Punishment",
				"Poison-Jab",
				"Night-Slash",
				"Seed-Bomb",
				"Vacuum-Wave",
				"Focus-Blast",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Acrobatics",
				"Retaliate",
				"Final-Gambit",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch",
				"Power-Trip",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion
}