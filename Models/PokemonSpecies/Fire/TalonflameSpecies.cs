using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Talonflame Species to store common natural stats of all Talonflames
	#region TalonflameSpecies
	public class TalonflameSpecies : PokemonSpecies
	{
#nullable enable
		private static TalonflameSpecies? _instance = null;
#nullable restore
        public static TalonflameSpecies Instance => _instance ?? (_instance = new TalonflameSpecies());

		#region TalonflameSpecies Constructor
		public TalonflameSpecies() : base(
			663,
			"Talonflame",
			Fire.Instance, Flying.Instance,
			1.2,
			24.5,
			new PokemonStats(
				78, // HPs
				81, 71, // Attack & Defense
				74, 69, // Spacial Attack & Defense
				126 // Speed
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
				"Hyper-Beam",
				"Peck",
				"Solar-Beam",
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
				"Bulk-Up",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Me-First",
				"Flare-Blitz",
				"Brave-Bird",
				"Giga-Impact",
				"Hone-Claws",
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