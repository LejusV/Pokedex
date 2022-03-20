using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Heracross Species to store common natural stats of all Heracrosss
	#region HeracrossSpecies
	public class HeracrossSpecies : PokemonSpecies
	{
#nullable enable
		private static HeracrossSpecies? _instance = null;
#nullable restore
        public static HeracrossSpecies Instance => _instance ?? (_instance = new HeracrossSpecies());

		#region HeracrossSpecies Constructor
		public HeracrossSpecies() : base(
			214,
			"Heracross",
			Bug.Instance, Fighting.Instance,
			1.5,
			54.0,
			new PokemonStats(
				80, // HPs
				125, 75, // Attack & Defense
				40, 95, // Spacial Attack & Defense
				85 // Speed
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Pin-Missile",
				"Leer",
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
				"Harden",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Reversal",
				"Protect",
				"Detect",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Arm-Thrust",
				"Rock-Tomb",
				"Bullet-Seed",
				"Aerial-Ace",
				"Iron-Defense",
				"Bulk-Up",
				"Rock-Blast",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Night-Slash",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Stone-Edge",
				"Captivate",
				"Bug-Bite",
				"Venoshock",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Retaliate",
				"Struggle-Bug",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}