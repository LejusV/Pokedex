using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Croagunk Species to store common natural stats of all Croagunks
	#region CroagunkSpecies
	public class CroagunkSpecies : PokemonSpecies
	{
#nullable enable
		private static CroagunkSpecies? _instance = null;
#nullable restore
        public static CroagunkSpecies Instance => _instance ?? (_instance = new CroagunkSpecies());

		#region CroagunkSpecies Constructor
		public CroagunkSpecies() : base(
			453,
			"Croagunk",
			Poison.Instance, Fighting.Instance,
			0.7,
			23.0,
			new PokemonStats(
				48, // HPs
				61, 40, // Attack & Defense
				61, 40, // Spacial Attack & Defense
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
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Poison-Sting",
				"Low-Kick",
				"Counter",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Meditate",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Torment",
				"Flatter",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Bulk-Up",
				"Bounce",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Feint",
				"Acupressure",
				"Payback",
				"Embargo",
				"Fling",
				"Me-First",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Nasty-Plot",
				"Bullet-Punch",
				"Mud-Bomb",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}