using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pheromosa Species to store common natural stats of all Pheromosas
	#region PheromosaSpecies
	public class PheromosaSpecies : PokemonSpecies
	{
#nullable enable
		private static PheromosaSpecies? _instance = null;
#nullable restore
        public static PheromosaSpecies Instance => _instance ?? (_instance = new PheromosaSpecies());

		#region PheromosaSpecies Constructor
		public PheromosaSpecies() : base(
			795,
			"Pheromosa",
			Bug.Instance, Fighting.Instance,
			1.8,
			25.0,
			new PokemonStats(
				71, // HPs
				137, 37, // Attack & Defense
				137, 37, // Spacial Attack & Defense
				151 // Speed
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
				"Jump-Kick",
				"Leer",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Toxic",
				"Agility",
				"Double-Team",
				"Swift",
				"High-Jump-Kick",
				"Rest",
				"Substitute",
				"Triple-Kick",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Silver-Wind",
				"Bounce",
				"Roost",
				"Feint",
				"U-Turn",
				"Fling",
				"Me-First",
				"Poison-Jab",
				"Bug-Buzz",
				"Focus-Blast",
				"Giga-Impact",
				"Quiver-Dance",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Confide",
				"Lunge",
				"Speed-Swap"
			};
		}
		#endregion
	}
	#endregion
}