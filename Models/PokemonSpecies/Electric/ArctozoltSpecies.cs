using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Arctozolt Species to store common natural stats of all Arctozolts
	#region ArctozoltSpecies
	public class ArctozoltSpecies : PokemonSpecies
	{
#nullable enable
		private static ArctozoltSpecies? _instance = null;
#nullable restore
        public static ArctozoltSpecies Instance => _instance ?? (_instance = new ArctozoltSpecies());

		#region ArctozoltSpecies Constructor
		public ArctozoltSpecies() : base(
			881,
			"Arctozolt",
			Electric.Instance, Ice.Instance,
			2.3,
			150.0,
			new PokemonStats(
				90, // HPs
				100, 90, // Attack & Defense
				90, 80, // Spacial Attack & Defense
				55 // Speed
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