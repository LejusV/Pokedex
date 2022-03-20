using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Milcery Species to store common natural stats of all Milcerys
	#region MilcerySpecies
	public class MilcerySpecies : PokemonSpecies
	{
#nullable enable
		private static MilcerySpecies? _instance = null;
#nullable restore
        public static MilcerySpecies Instance => _instance ?? (_instance = new MilcerySpecies());

		#region MilcerySpecies Constructor
		public MilcerySpecies() : base(
			868,
			"Milcery",
			Fairy.Instance,
			0.2,
			0.3,
			new PokemonStats(
				45, // HPs
				40, 40, // Attack & Defense
				50, 61, // Spacial Attack & Defense
				34 // Speed
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