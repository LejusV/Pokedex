using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Toxicroak Species to store common natural stats of all Toxicroaks
	#region ToxicroakSpecies
	public class ToxicroakSpecies : PokemonSpecies
	{
#nullable enable
		private static ToxicroakSpecies? _instance = null;
#nullable restore
        public static ToxicroakSpecies Instance => _instance ?? (_instance = new ToxicroakSpecies());

		#region ToxicroakSpecies Constructor
		public ToxicroakSpecies() : base(
			454,
			"Toxicroak",
			Poison.Instance, Fighting.Instance,
			1.3,
			44.4,
			new PokemonStats(
				83, // HPs
				106, 65, // Attack & Defense
				86, 65, // Spacial Attack & Defense
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
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Poison-Sting",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
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
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Flatter",
				"Facade",
				"Focus-Punch",
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
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Mud-Bomb",
				"Rock-Climb",
				"Gunk-Shot",
				"Stone-Edge",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Low-Sweep",
				"Foul-Play",
				"Round",
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