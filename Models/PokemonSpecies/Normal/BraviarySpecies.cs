using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Braviary Species to store common natural stats of all Braviarys
	#region BraviarySpecies
	public class BraviarySpecies : PokemonSpecies
	{
#nullable enable
		private static BraviarySpecies? _instance = null;
#nullable restore
        public static BraviarySpecies Instance => _instance ?? (_instance = new BraviarySpecies());

		#region BraviarySpecies Constructor
		public BraviarySpecies() : base(
			628,
			"Braviary",
			Normal.Instance, Flying.Instance,
			1.5,
			41.0,
			new PokemonStats(
				100, // HPs
				123, 75, // Attack & Defense
				57, 75, // Spacial Attack & Defense
				80 // Speed
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
				"Hyper-Beam",
				"Peck",
				"Strength",
				"Toxic",
				"Double-Team",
				"Sky-Attack",
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
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
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