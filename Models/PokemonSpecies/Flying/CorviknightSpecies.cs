using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Corviknight Species to store common natural stats of all Corviknights
	#region CorviknightSpecies
	public class CorviknightSpecies : PokemonSpecies
	{
#nullable enable
		private static CorviknightSpecies? _instance = null;
#nullable restore
        public static CorviknightSpecies Instance => _instance ?? (_instance = new CorviknightSpecies());

		#region CorviknightSpecies Constructor
		public CorviknightSpecies() : base(
			823,
			"Corviknight",
			Flying.Instance, Steel.Instance,
			2.2,
			75.0,
			new PokemonStats(
				98, // HPs
				87, 105, // Attack & Defense
				53, 85, // Spacial Attack & Defense
				67 // Speed
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