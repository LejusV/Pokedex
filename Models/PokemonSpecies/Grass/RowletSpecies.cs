using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rowlet Species to store common natural stats of all Rowlets
	#region RowletSpecies
	public class RowletSpecies : PokemonSpecies
	{
#nullable enable
		private static RowletSpecies? _instance = null;
#nullable restore
        public static RowletSpecies Instance => _instance ?? (_instance = new RowletSpecies());

		#region RowletSpecies Constructor
		public RowletSpecies() : base(
			722,
			"Rowlet",
			Grass.Instance, Flying.Instance,
			0.3,
			1.5,
			new PokemonStats(
				68, // HPs
				55, 55, // Attack & Defense
				50, 50, // Spacial Attack & Defense
				42 // Speed
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
				"Fury-Attack",
				"Tackle",
				"Growl",
				"Peck",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Haze",
				"Rest",
				"Substitute",
				"Curse",
				"Protect",
				"Foresight",
				"False-Swipe",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Feather-Dance",
				"Astonish",
				"Leaf-Blade",
				"Roost",
				"Pluck",
				"Sucker-Punch",
				"Energy-Ball",
				"Brave-Bird",
				"Nasty-Plot",
				"Shadow-Claw",
				"Defog",
				"Grass-Knot",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Work-Up",
				"Confide",
				"Leafage"
			};
		}
		#endregion
	}
	#endregion
}