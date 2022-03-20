using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Fletchling Species to store common natural stats of all Fletchlings
	#region FletchlingSpecies
	public class FletchlingSpecies : PokemonSpecies
	{
#nullable enable
		private static FletchlingSpecies? _instance = null;
#nullable restore
        public static FletchlingSpecies Instance => _instance ?? (_instance = new FletchlingSpecies());

		#region FletchlingSpecies Constructor
		public FletchlingSpecies() : base(
			661,
			"Fletchling",
			Normal.Instance, Flying.Instance,
			0.3,
			1.7,
			new PokemonStats(
				45, // HPs
				50, 43, // Attack & Defense
				40, 38, // Spacial Attack & Defense
				62 // Speed
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
				"Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
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
				"Quick-Guard",
				"Acrobatics",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}