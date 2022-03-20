using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Perrserker Species to store common natural stats of all Perrserkers
	#region PerrserkerSpecies
	public class PerrserkerSpecies : PokemonSpecies
	{
#nullable enable
		private static PerrserkerSpecies? _instance = null;
#nullable restore
        public static PerrserkerSpecies Instance => _instance ?? (_instance = new PerrserkerSpecies());

		#region PerrserkerSpecies Constructor
		public PerrserkerSpecies() : base(
			863,
			"Perrserker",
			Steel.Instance,
			0.8,
			28.0,
			new PokemonStats(
				70, // HPs
				110, 100, // Attack & Defense
				50, 60, // Spacial Attack & Defense
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