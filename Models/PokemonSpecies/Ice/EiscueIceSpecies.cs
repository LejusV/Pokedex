using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Eiscue-Ice Species to store common natural stats of all Eiscue-Ices
	#region Eiscue-IceSpecies
	public class EiscueIceSpecies : PokemonSpecies
	{
#nullable enable
		private static EiscueIceSpecies? _instance = null;
#nullable restore
        public static EiscueIceSpecies Instance => _instance ?? (_instance = new EiscueIceSpecies());

		#region Eiscue-IceSpecies Constructor
		public EiscueIceSpecies() : base(
			875,
			"Eiscue-Ice",
			Ice.Instance,
			1.4,
			89.0,
			new PokemonStats(
				75, // HPs
				80, 110, // Attack & Defense
				65, 90, // Spacial Attack & Defense
				50 // Speed
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