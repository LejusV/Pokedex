using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Stonjourner Species to store common natural stats of all Stonjourners
	#region StonjournerSpecies
	public class StonjournerSpecies : PokemonSpecies
	{
#nullable enable
		private static StonjournerSpecies? _instance = null;
#nullable restore
        public static StonjournerSpecies Instance => _instance ?? (_instance = new StonjournerSpecies());

		#region StonjournerSpecies Constructor
		public StonjournerSpecies() : base(
			874,
			"Stonjourner",
			Rock.Instance,
			2.5,
			520.0,
			new PokemonStats(
				100, // HPs
				125, 135, // Attack & Defense
				20, 20, // Spacial Attack & Defense
				70 // Speed
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