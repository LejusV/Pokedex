using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hattrem Species to store common natural stats of all Hattrems
	#region HattremSpecies
	public class HattremSpecies : PokemonSpecies
	{
#nullable enable
		private static HattremSpecies? _instance = null;
#nullable restore
        public static HattremSpecies Instance => _instance ?? (_instance = new HattremSpecies());

		#region HattremSpecies Constructor
		public HattremSpecies() : base(
			857,
			"Hattrem",
			Psychic.Instance,
			0.6,
			4.8,
			new PokemonStats(
				57, // HPs
				40, 65, // Attack & Defense
				86, 73, // Spacial Attack & Defense
				49 // Speed
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