using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Fraxure Species to store common natural stats of all Fraxures
	#region FraxureSpecies
	public class FraxureSpecies : PokemonSpecies
	{
#nullable enable
		private static FraxureSpecies? _instance = null;
#nullable restore
        public static FraxureSpecies Instance => _instance ?? (_instance = new FraxureSpecies());

		#region FraxureSpecies Constructor
		public FraxureSpecies() : base(
			611,
			"Fraxure",
			Dragon.Instance,
			1.0,
			36.0,
			new PokemonStats(
				66, // HPs
				117, 70, // Attack & Defense
				40, 50, // Spacial Attack & Defense
				67 // Speed
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
				"Scratch",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Leer",
				"Roar",
				"Low-Kick",
				"Strength",
				"Dragon-Rage",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Outrage",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Shock-Wave",
				"Payback",
				"Assurance",
				"Fling",
				"Poison-Jab",
				"Aqua-Tail",
				"X-Scissor",
				"Dragon-Pulse",
				"Giga-Impact",
				"Shadow-Claw",
				"Draco-Meteor",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Dragon-Tail",
				"Dual-Chop",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}