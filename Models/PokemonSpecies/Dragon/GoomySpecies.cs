using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Goomy Species to store common natural stats of all Goomys
	#region GoomySpecies
	public class GoomySpecies : PokemonSpecies
	{
#nullable enable
		private static GoomySpecies? _instance = null;
#nullable restore
        public static GoomySpecies Instance => _instance ?? (_instance = new GoomySpecies());

		#region GoomySpecies Constructor
		public GoomySpecies() : base(
			704,
			"Goomy",
			Dragon.Instance,
			0.3,
			2.8,
			new PokemonStats(
				45, // HPs
				50, 35, // Attack & Defense
				55, 75, // Spacial Attack & Defense
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
				"Tackle",
				"Body-Slam",
				"Counter",
				"Absorb",
				"Thunderbolt",
				"Toxic",
				"Double-Team",
				"Bide",
				"Bubble",
				"Acid-Armor",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Secret-Power",
				"Muddy-Water",
				"Poison-Tail",
				"Shock-Wave",
				"Water-Pulse",
				"Dragon-Pulse",
				"Draco-Meteor",
				"Sludge-Wave",
				"Round",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}