using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shedinja Species to store common natural stats of all Shedinjas
	#region ShedinjaSpecies
	public class ShedinjaSpecies : PokemonSpecies
	{
#nullable enable
		private static ShedinjaSpecies? _instance = null;
#nullable restore
        public static ShedinjaSpecies Instance => _instance ?? (_instance = new ShedinjaSpecies());

		#region ShedinjaSpecies Constructor
		public ShedinjaSpecies() : base(
			292,
			"Shedinja",
			Bug.Instance, Ghost.Instance,
			0.8,
			1.2,
			new PokemonStats(
				1, // HPs
				90, 45, // Attack & Defense
				30, 30, // Spacial Attack & Defense
				40 // Speed
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
				"Scratch",
				"Cut",
				"Sand-Attack",
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Confuse-Ray",
				"Dream-Eater",
				"Leech-Life",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Nightmare",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Facade",
				"Trick",
				"Grudge",
				"Secret-Power",
				"Aerial-Ace",
				"Natural-Gift",
				"Heal-Block",
				"Sucker-Punch",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Bug-Bite",
				"Hone-Claws",
				"Telekinesis",
				"Round",
				"Struggle-Bug",
				"Phantom-Force",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}