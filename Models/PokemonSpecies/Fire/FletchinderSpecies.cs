using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Fletchinder Species to store common natural stats of all Fletchinders
	#region FletchinderSpecies
	public class FletchinderSpecies : PokemonSpecies
	{
#nullable enable
		private static FletchinderSpecies? _instance = null;
#nullable restore
        public static FletchinderSpecies Instance => _instance ?? (_instance = new FletchinderSpecies());

		#region FletchinderSpecies Constructor
		public FletchinderSpecies() : base(
			662,
			"Fletchinder",
			Fire.Instance, Flying.Instance,
			0.7,
			16.0,
			new PokemonStats(
				62, // HPs
				73, 55, // Attack & Defense
				56, 52, // Spacial Attack & Defense
				84 // Speed
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
				"Razor-Wind",
				"Swords-Dance",
				"Fly",
				"Tackle",
				"Growl",
				"Ember",
				"Flamethrower",
				"Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Me-First",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}