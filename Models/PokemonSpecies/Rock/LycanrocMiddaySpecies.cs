using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lycanroc-Midday Species to store common natural stats of all Lycanroc-Middays
	#region Lycanroc-MiddaySpecies
	public class LycanrocMiddaySpecies : PokemonSpecies
	{
#nullable enable
		private static LycanrocMiddaySpecies? _instance = null;
#nullable restore
        public static LycanrocMiddaySpecies Instance => _instance ?? (_instance = new LycanrocMiddaySpecies());

		#region Lycanroc-MiddaySpecies Constructor
		public LycanrocMiddaySpecies() : base(
			745,
			"Lycanroc-Midday",
			Rock.Instance,
			0.8,
			25.0,
			new PokemonStats(
				75, // HPs
				115, 65, // Attack & Defense
				55, 65, // Spacial Attack & Defense
				112 // Speed
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
				"Sand-Attack",
				"Tackle",
				"Leer",
				"Bite",
				"Roar",
				"Rock-Throw",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Crunch",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Howl",
				"Bulk-Up",
				"Rock-Polish",
				"Rock-Climb",
				"Stone-Edge",
				"Stealth-Rock",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Snarl",
				"Confide",
				"Accelerock"
			};
		}
		#endregion
	}
	#endregion
}