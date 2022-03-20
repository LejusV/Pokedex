using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dartrix Species to store common natural stats of all Dartrixs
	#region DartrixSpecies
	public class DartrixSpecies : PokemonSpecies
	{
#nullable enable
		private static DartrixSpecies? _instance = null;
#nullable restore
        public static DartrixSpecies Instance => _instance ?? (_instance = new DartrixSpecies());

		#region DartrixSpecies Constructor
		public DartrixSpecies() : base(
			723,
			"Dartrix",
			Grass.Instance, Flying.Instance,
			0.7,
			16.0,
			new PokemonStats(
				78, // HPs
				75, 75, // Attack & Defense
				70, 70, // Spacial Attack & Defense
				52 // Speed
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
				"Light-Screen",
				"Rest",
				"Substitute",
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