using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Thievul Species to store common natural stats of all Thievuls
	#region ThievulSpecies
	public class ThievulSpecies : PokemonSpecies
	{
#nullable enable
		private static ThievulSpecies? _instance = null;
#nullable restore
        public static ThievulSpecies Instance => _instance ?? (_instance = new ThievulSpecies());

		#region ThievulSpecies Constructor
		public ThievulSpecies() : base(
			828,
			"Thievul",
			Dark.Instance,
			1.2,
			19.9,
			new PokemonStats(
				70, // HPs
				58, 58, // Attack & Defense
				87, 92, // Spacial Attack & Defense
				90 // Speed
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