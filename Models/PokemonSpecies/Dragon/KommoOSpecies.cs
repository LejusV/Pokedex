using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kommo-O Species to store common natural stats of all Kommo-Os
	#region Kommo-OSpecies
	public class KommoOSpecies : PokemonSpecies
	{
#nullable enable
		private static KommoOSpecies? _instance = null;
#nullable restore
        public static KommoOSpecies Instance => _instance ?? (_instance = new KommoOSpecies());

		#region Kommo-OSpecies Constructor
		public KommoOSpecies() : base(
			784,
			"Kommo-O",
			Dragon.Instance, Fighting.Instance,
			1.6,
			78.2,
			new PokemonStats(
				75, // HPs
				110, 125, // Attack & Defense
				100, 105, // Spacial Attack & Defense
				85 // Speed
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
				"Flamethrower",
				"Hyper-Beam",
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
				"Belly-Drum",
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
				"Rock-Polish",
				"Poison-Jab",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Flash-Cannon",
				"Draco-Meteor",
				"Autotomize",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Noble-Roar",
				"Confide",
				"Clanging-Scales",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}