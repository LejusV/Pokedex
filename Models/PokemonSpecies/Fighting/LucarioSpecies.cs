using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lucario Species to store common natural stats of all Lucarios
	#region LucarioSpecies
	public class LucarioSpecies : PokemonSpecies
	{
#nullable enable
		private static LucarioSpecies? _instance = null;
#nullable restore
        public static LucarioSpecies Instance => _instance ?? (_instance = new LucarioSpecies());

		#region LucarioSpecies Constructor
		public LucarioSpecies() : base(
			448,
			"Lucario",
			Fighting.Instance, Steel.Instance,
			1.2,
			54.0,
			new PokemonStats(
				70, // HPs
				110, 70, // Attack & Defense
				115, 70, // Spacial Attack & Defense
				90 // Speed
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
				"Headbutt",
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Double-Team",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Bone-Rush",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Extreme-Speed",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Iron-Defense",
				"Bulk-Up",
				"Calm-Mind",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Payback",
				"Fling",
				"Me-First",
				"Magnet-Rise",
				"Force-Palm",
				"Aura-Sphere",
				"Poison-Jab",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Heal-Pulse",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch",
				"Laser-Focus"
			};
		}
		#endregion
	}
	#endregion
}