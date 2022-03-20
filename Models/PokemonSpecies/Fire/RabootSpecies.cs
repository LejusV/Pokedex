using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Raboot Species to store common natural stats of all Raboots
	#region RabootSpecies
	public class RabootSpecies : PokemonSpecies
	{
#nullable enable
		private static RabootSpecies? _instance = null;
#nullable restore
        public static RabootSpecies Instance => _instance ?? (_instance = new RabootSpecies());

		#region RabootSpecies Constructor
		public RabootSpecies() : base(
			814,
			"Raboot",
			Fire.Instance,
			0.6,
			9.0,
			new PokemonStats(
				65, // HPs
				86, 60, // Attack & Defense
				55, 60, // Spacial Attack & Defense
				94 // Speed
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
				
			};
		}
		#endregion
	}
	#endregion
}