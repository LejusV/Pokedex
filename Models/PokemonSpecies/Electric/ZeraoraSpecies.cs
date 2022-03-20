using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zeraora Species to store common natural stats of all Zeraoras
	#region ZeraoraSpecies
	public class ZeraoraSpecies : PokemonSpecies
	{
#nullable enable
		private static ZeraoraSpecies? _instance = null;
#nullable restore
        public static ZeraoraSpecies Instance => _instance ?? (_instance = new ZeraoraSpecies());

		#region ZeraoraSpecies Constructor
		public ZeraoraSpecies() : base(
			807,
			"Zeraora",
			Electric.Instance,
			1.5,
			44.5,
			new PokemonStats(
				88, // HPs
				112, 75, // Attack & Defense
				102, 80, // Spacial Attack & Defense
				143 // Speed
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
				"Thunder-Punch",
				"Scratch",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Protect",
				"False-Swipe",
				"Spark",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Fake-Out",
				"Facade",
				"Charge",
				"Taunt",
				"Brick-Break",
				"Aerial-Ace",
				"Bulk-Up",
				"Calm-Mind",
				"Close-Combat",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Discharge",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Acrobatics",
				"Volt-Switch",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Brutal-Swing",
				"Plasma-Fists"
			};
		}
		#endregion
	}
	#endregion
}