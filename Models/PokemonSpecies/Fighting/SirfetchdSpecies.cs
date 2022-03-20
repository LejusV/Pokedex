using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sirfetchd Species to store common natural stats of all Sirfetchds
	#region SirfetchdSpecies
	public class SirfetchdSpecies : PokemonSpecies
	{
#nullable enable
		private static SirfetchdSpecies? _instance = null;
#nullable restore
        public static SirfetchdSpecies Instance => _instance ?? (_instance = new SirfetchdSpecies());

		#region SirfetchdSpecies Constructor
		public SirfetchdSpecies() : base(
			865,
			"Sirfetchd",
			Fighting.Instance,
			0.8,
			117.0,
			new PokemonStats(
				62, // HPs
				135, 95, // Attack & Defense
				68, 82, // Spacial Attack & Defense
				65 // Speed
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