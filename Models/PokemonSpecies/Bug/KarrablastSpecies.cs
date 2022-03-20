using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Karrablast Species to store common natural stats of all Karrablasts
	#region KarrablastSpecies
	public class KarrablastSpecies : PokemonSpecies
	{
#nullable enable
		private static KarrablastSpecies? _instance = null;
#nullable restore
        public static KarrablastSpecies Instance => _instance ?? (_instance = new KarrablastSpecies());

		#region KarrablastSpecies Constructor
		public KarrablastSpecies() : base(
			588,
			"Karrablast",
			Bug.Instance,
			0.5,
			5.9,
			new PokemonStats(
				50, // HPs
				75, 45, // Attack & Defense
				40, 45, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Peck",
				"Counter",
				"Toxic",
				"Screech",
				"Double-Team",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Buzz",
				"Energy-Ball",
				"Bug-Bite",
				"Round",
				"Struggle-Bug",
				"Drill-Run",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}