using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Impidimp Species to store common natural stats of all Impidimps
	#region ImpidimpSpecies
	public class ImpidimpSpecies : PokemonSpecies
	{
#nullable enable
		private static ImpidimpSpecies? _instance = null;
#nullable restore
        public static ImpidimpSpecies Instance => _instance ?? (_instance = new ImpidimpSpecies());

		#region ImpidimpSpecies Constructor
		public ImpidimpSpecies() : base(
			859,
			"Impidimp",
			Dark.Instance, Fairy.Instance,
			0.4,
			5.5,
			new PokemonStats(
				45, // HPs
				45, 30, // Attack & Defense
				55, 40, // Spacial Attack & Defense
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