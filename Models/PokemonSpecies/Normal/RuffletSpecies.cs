using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rufflet Species to store common natural stats of all Rufflets
	#region RuffletSpecies
	public class RuffletSpecies : PokemonSpecies
	{
#nullable enable
		private static RuffletSpecies? _instance = null;
#nullable restore
        public static RuffletSpecies Instance => _instance ?? (_instance = new RuffletSpecies());

		#region RuffletSpecies Constructor
		public RuffletSpecies() : base(
			627,
			"Rufflet",
			Normal.Instance, Flying.Instance,
			0.5,
			10.5,
			new PokemonStats(
				70, // HPs
				83, 50, // Attack & Defense
				37, 50, // Spacial Attack & Defense
				60 // Speed
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
				"Cut",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Fury-Attack",
				"Thrash",
				"Leer",
				"Peck",
				"Strength",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Superpower",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Brave-Bird",
				"Shadow-Claw",
				"Defog",
				"Hone-Claws",
				"Round",
				"Sky-Drop",
				"Retaliate",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}