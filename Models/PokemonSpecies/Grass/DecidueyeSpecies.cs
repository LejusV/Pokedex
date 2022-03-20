using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Decidueye Species to store common natural stats of all Decidueyes
	#region DecidueyeSpecies
	public class DecidueyeSpecies : PokemonSpecies
	{
#nullable enable
		private static DecidueyeSpecies? _instance = null;
#nullable restore
        public static DecidueyeSpecies Instance => _instance ?? (_instance = new DecidueyeSpecies());

		#region DecidueyeSpecies Constructor
		public DecidueyeSpecies() : base(
			724,
			"Decidueye",
			Grass.Instance, Ghost.Instance,
			1.6,
			36.6,
			new PokemonStats(
				78, // HPs
				107, 75, // Attack & Defense
				100, 100, // Spacial Attack & Defense
				70 // Speed
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
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Feather-Dance",
				"Astonish",
				"Frenzy-Plant",
				"Leaf-Blade",
				"Roost",
				"Pluck",
				"U-Turn",
				"Sucker-Punch",
				"Energy-Ball",
				"Brave-Bird",
				"Giga-Impact",
				"Nasty-Plot",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Leaf-Storm",
				"Grass-Knot",
				"Ominous-Wind",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Grass-Pledge",
				"Work-Up",
				"Phantom-Force",
				"Confide",
				"Spirit-Shackle",
				"Leafage"
			};
		}
		#endregion
	}
	#endregion
}