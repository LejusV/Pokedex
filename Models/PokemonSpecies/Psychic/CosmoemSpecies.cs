using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cosmoem Species to store common natural stats of all Cosmoems
	#region CosmoemSpecies
	public class CosmoemSpecies : PokemonSpecies
	{
#nullable enable
		private static CosmoemSpecies? _instance = null;
#nullable restore
        public static CosmoemSpecies Instance => _instance ?? (_instance = new CosmoemSpecies());

		#region CosmoemSpecies Constructor
		public CosmoemSpecies() : base(
			790,
			"Cosmoem",
			Psychic.Instance,
			0.1,
			999.9,
			new PokemonStats(
				43, // HPs
				29, 131, // Attack & Defense
				29, 131, // Spacial Attack & Defense
				37 // Speed
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
				"Teleport",
				"Cosmic-Power"
			};
		}
		#endregion
	}
	#endregion
}