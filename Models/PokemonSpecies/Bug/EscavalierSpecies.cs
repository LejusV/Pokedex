using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Escavalier Species to store common natural stats of all Escavaliers
	#region EscavalierSpecies
	public class EscavalierSpecies : PokemonSpecies
	{
#nullable enable
		private static EscavalierSpecies? _instance = null;
#nullable restore
        public static EscavalierSpecies Instance => _instance ?? (_instance = new EscavalierSpecies());

		#region EscavalierSpecies Constructor
		public EscavalierSpecies() : base(
			589,
			"Escavalier",
			Bug.Instance, Steel.Instance,
			1.0,
			33.0,
			new PokemonStats(
				70, // HPs
				135, 105, // Attack & Defense
				60, 105, // Spacial Attack & Defense
				20 // Speed
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
				"Headbutt",
				"Fury-Attack",
				"Double-Edge",
				"Twineedle",
				"Leer",
				"Hyper-Beam",
				"Peck",
				"Toxic",
				"Double-Team",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Giga-Drain",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Buzz",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Iron-Head",
				"Bug-Bite",
				"Round",
				"Quick-Guard",
				"Struggle-Bug",
				"Drill-Run",
				"Fell-Stinger",
				"Confide",
				"Infestation",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}