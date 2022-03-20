using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hakamo-O Species to store common natural stats of all Hakamo-Os
	#region Hakamo-OSpecies
	public class HakamoOSpecies : PokemonSpecies
	{
#nullable enable
		private static HakamoOSpecies? _instance = null;
#nullable restore
        public static HakamoOSpecies Instance => _instance ?? (_instance = new HakamoOSpecies());

		#region Hakamo-OSpecies Constructor
		public HakamoOSpecies() : base(
			783,
			"Hakamo-O",
			Dragon.Instance, Fighting.Instance,
			1.2,
			47.0,
			new PokemonStats(
				55, // HPs
				75, 90, // Attack & Defense
				65, 70, // Spacial Attack & Defense
				65 // Speed
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
				"Headbutt",
				"Tackle",
				"Leer",
				"Roar",
				"Earthquake",
				"Toxic",
				"Screech",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Sandstorm",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Dragon-Dance",
				"Close-Combat",
				"Payback",
				"Fling",
				"X-Scissor",
				"Focus-Blast",
				"Shadow-Claw",
				"Draco-Meteor",
				"Autotomize",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Noble-Roar",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}