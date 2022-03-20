using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Alcremie Species to store common natural stats of all Alcremies
	#region AlcremieSpecies
	public class AlcremieSpecies : PokemonSpecies
	{
#nullable enable
		private static AlcremieSpecies? _instance = null;
#nullable restore
        public static AlcremieSpecies Instance => _instance ?? (_instance = new AlcremieSpecies());

		#region AlcremieSpecies Constructor
		public AlcremieSpecies() : base(
			869,
			"Alcremie",
			Fairy.Instance,
			0.3,
			0.5,
			new PokemonStats(
				65, // HPs
				60, 75, // Attack & Defense
				110, 121, // Spacial Attack & Defense
				64 // Speed
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