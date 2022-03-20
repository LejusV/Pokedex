using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Jangmo-O Species to store common natural stats of all Jangmo-Os
	#region Jangmo-OSpecies
	public class JangmoOSpecies : PokemonSpecies
	{
#nullable enable
		private static JangmoOSpecies? _instance = null;
#nullable restore
        public static JangmoOSpecies Instance => _instance ?? (_instance = new JangmoOSpecies());

		#region Jangmo-OSpecies Constructor
		public JangmoOSpecies() : base(
			782,
			"Jangmo-O",
			Dragon.Instance,
			0.6,
			29.7,
			new PokemonStats(
				45, // HPs
				55, 65, // Attack & Defense
				45, 45, // Spacial Attack & Defense
				45 // Speed
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
				"Counter",
				"Earthquake",
				"Toxic",
				"Screech",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Reversal",
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
				"Dragon-Breath",
				"Hidden-Power",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Dragon-Dance",
				"Payback",
				"X-Scissor",
				"Focus-Blast",
				"Shadow-Claw",
				"Draco-Meteor",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Noble-Roar",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}