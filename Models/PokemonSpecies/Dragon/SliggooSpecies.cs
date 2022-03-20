using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sliggoo Species to store common natural stats of all Sliggoos
	#region SliggooSpecies
	public class SliggooSpecies : PokemonSpecies
	{
#nullable enable
		private static SliggooSpecies? _instance = null;
#nullable restore
        public static SliggooSpecies Instance => _instance ?? (_instance = new SliggooSpecies());

		#region SliggooSpecies Constructor
		public SliggooSpecies() : base(
			705,
			"Sliggoo",
			Dragon.Instance,
			0.8,
			17.5,
			new PokemonStats(
				68, // HPs
				75, 53, // Attack & Defense
				83, 113, // Spacial Attack & Defense
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
				"Tackle",
				"Body-Slam",
				"Ice-Beam",
				"Blizzard",
				"Absorb",
				"Thunderbolt",
				"Toxic",
				"Double-Team",
				"Bide",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Outrage",
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