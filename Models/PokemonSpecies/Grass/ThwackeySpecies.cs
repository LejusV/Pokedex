using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Thwackey Species to store common natural stats of all Thwackeys
	#region ThwackeySpecies
	public class ThwackeySpecies : PokemonSpecies
	{
#nullable enable
		private static ThwackeySpecies? _instance = null;
#nullable restore
        public static ThwackeySpecies Instance => _instance ?? (_instance = new ThwackeySpecies());

		#region ThwackeySpecies Constructor
		public ThwackeySpecies() : base(
			811,
			"Thwackey",
			Grass.Instance,
			0.7,
			14.0,
			new PokemonStats(
				70, // HPs
				85, 70, // Attack & Defense
				55, 60, // Spacial Attack & Defense
				80 // Speed
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