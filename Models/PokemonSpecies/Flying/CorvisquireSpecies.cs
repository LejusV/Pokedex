using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Corvisquire Species to store common natural stats of all Corvisquires
	#region CorvisquireSpecies
	public class CorvisquireSpecies : PokemonSpecies
	{
#nullable enable
		private static CorvisquireSpecies? _instance = null;
#nullable restore
        public static CorvisquireSpecies Instance => _instance ?? (_instance = new CorvisquireSpecies());

		#region CorvisquireSpecies Constructor
		public CorvisquireSpecies() : base(
			822,
			"Corvisquire",
			Flying.Instance,
			0.8,
			16.0,
			new PokemonStats(
				68, // HPs
				67, 55, // Attack & Defense
				43, 55, // Spacial Attack & Defense
				77 // Speed
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