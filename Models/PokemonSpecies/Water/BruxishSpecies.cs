using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bruxish Species to store common natural stats of all Bruxishs
	#region BruxishSpecies
	public class BruxishSpecies : PokemonSpecies
	{
#nullable enable
		private static BruxishSpecies? _instance = null;
#nullable restore
        public static BruxishSpecies Instance => _instance ?? (_instance = new BruxishSpecies());

		#region BruxishSpecies Constructor
		public BruxishSpecies() : base(
			779,
			"Bruxish",
			Water.Instance, Psychic.Instance,
			0.9,
			19.0,
			new PokemonStats(
				68, // HPs
				105, 70, // Attack & Defense
				70, 70, // Spacial Attack & Defense
				92 // Speed
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
				"Bite",
				"Disable",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Waterfall",
				"Dream-Eater",
				"Psywave",
				"Rest",
				"Substitute",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Torment",
				"Facade",
				"Taunt",
				"Poison-Fang",
				"Astonish",
				"Aerial-Ace",
				"Bulk-Up",
				"Calm-Mind",
				"Water-Pulse",
				"Payback",
				"Embargo",
				"Fling",
				"Aqua-Tail",
				"Giga-Impact",
				"Ice-Fang",
				"Trick-Room",
				"Aqua-Jet",
				"Venoshock",
				"Synchronoise",
				"Round",
				"Scald",
				"Frost-Breath",
				"Confide",
				"Psychic-Fangs"
			};
		}
		#endregion
	}
	#endregion
}