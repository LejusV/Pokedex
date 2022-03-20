using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mudsdale Species to store common natural stats of all Mudsdales
	#region MudsdaleSpecies
	public class MudsdaleSpecies : PokemonSpecies
	{
#nullable enable
		private static MudsdaleSpecies? _instance = null;
#nullable restore
        public static MudsdaleSpecies Instance => _instance ?? (_instance = new MudsdaleSpecies());

		#region MudsdaleSpecies Constructor
		public MudsdaleSpecies() : base(
			750,
			"Mudsdale",
			Ground.Instance,
			2.5,
			920.0,
			new PokemonStats(
				100, // HPs
				125, 100, // Attack & Defense
				55, 85, // Spacial Attack & Defense
				35 // Speed
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
				"Stomp",
				"Double-Kick",
				"Mega-Kick",
				"Roar",
				"Counter",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Facade",
				"Superpower",
				"Mud-Sport",
				"Rock-Tomb",
				"Iron-Defense",
				"Payback",
				"Focus-Blast",
				"Giga-Impact",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Rototiller",
				"Confide",
				"High-Horsepower"
			};
		}
		#endregion
	}
	#endregion
}