using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ditto Species to store common natural stats of all Dittos
	#region DittoSpecies
	public class DittoSpecies : PokemonSpecies
	{
#nullable enable
		private static DittoSpecies? _instance = null;
#nullable restore
        public static DittoSpecies Instance => _instance ?? (_instance = new DittoSpecies());

		#region DittoSpecies Constructor
		public DittoSpecies() : base(
			132,
			"Ditto",
			Normal.Instance,
			0.3,
			4.0,
			new PokemonStats(
				48, // HPs
				48, 48, // Attack & Defense
				48, 48, // Spacial Attack & Defense
				48 // Speed
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
				"Transform"
			};
		}
		#endregion
	}
	#endregion
}