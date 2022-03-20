using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Spewpa Species to store common natural stats of all Spewpas
	#region SpewpaSpecies
	public class SpewpaSpecies : PokemonSpecies
	{
#nullable enable
		private static SpewpaSpecies? _instance = null;
#nullable restore
        public static SpewpaSpecies Instance => _instance ?? (_instance = new SpewpaSpecies());

		#region SpewpaSpecies Constructor
		public SpewpaSpecies() : base(
			665,
			"Spewpa",
			Bug.Instance,
			0.3,
			8.4,
			new PokemonStats(
				45, // HPs
				22, 60, // Attack & Defense
				27, 30, // Spacial Attack & Defense
				29 // Speed
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
				"Harden",
				"Protect",
				"Iron-Defense",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion
}