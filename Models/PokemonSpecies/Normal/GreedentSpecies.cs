using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Greedent Species to store common natural stats of all Greedents
	#region GreedentSpecies
	public class GreedentSpecies : PokemonSpecies
	{
#nullable enable
		private static GreedentSpecies? _instance = null;
#nullable restore
        public static GreedentSpecies Instance => _instance ?? (_instance = new GreedentSpecies());

		#region GreedentSpecies Constructor
		public GreedentSpecies() : base(
			820,
			"Greedent",
			Normal.Instance,
			0.6,
			6.0,
			new PokemonStats(
				120, // HPs
				95, 95, // Attack & Defense
				55, 75, // Spacial Attack & Defense
				20 // Speed
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