using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Barraskewda Species to store common natural stats of all Barraskewdas
	#region BarraskewdaSpecies
	public class BarraskewdaSpecies : PokemonSpecies
	{
#nullable enable
		private static BarraskewdaSpecies? _instance = null;
#nullable restore
        public static BarraskewdaSpecies Instance => _instance ?? (_instance = new BarraskewdaSpecies());

		#region BarraskewdaSpecies Constructor
		public BarraskewdaSpecies() : base(
			847,
			"Barraskewda",
			Water.Instance,
			1.3,
			30.0,
			new PokemonStats(
				61, // HPs
				123, 60, // Attack & Defense
				60, 50, // Spacial Attack & Defense
				136 // Speed
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