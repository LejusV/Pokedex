using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Doublade Species to store common natural stats of all Doublades
	#region DoubladeSpecies
	public class DoubladeSpecies : PokemonSpecies
	{
#nullable enable
		private static DoubladeSpecies? _instance = null;
#nullable restore
        public static DoubladeSpecies Instance => _instance ?? (_instance = new DoubladeSpecies());

		#region DoubladeSpecies Constructor
		public DoubladeSpecies() : base(
			680,
			"Doublade",
			Steel.Instance, Ghost.Instance,
			0.8,
			4.5,
			new PokemonStats(
				59, // HPs
				110, 150, // Attack & Defense
				45, 49, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Tackle",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Shock-Wave",
				"Gyro-Ball",
				"Power-Trick",
				"Magnet-Rise",
				"Night-Slash",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Flash-Cannon",
				"Iron-Head",
				"Autotomize",
				"After-You",
				"Retaliate",
				"Sacred-Sword",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}