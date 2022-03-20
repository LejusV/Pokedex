using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Frosmoth Species to store common natural stats of all Frosmoths
	#region FrosmothSpecies
	public class FrosmothSpecies : PokemonSpecies
	{
#nullable enable
		private static FrosmothSpecies? _instance = null;
#nullable restore
        public static FrosmothSpecies Instance => _instance ?? (_instance = new FrosmothSpecies());

		#region FrosmothSpecies Constructor
		public FrosmothSpecies() : base(
			873,
			"Frosmoth",
			Ice.Instance, Bug.Instance,
			1.3,
			42.0,
			new PokemonStats(
				70, // HPs
				65, 60, // Attack & Defense
				125, 90, // Spacial Attack & Defense
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