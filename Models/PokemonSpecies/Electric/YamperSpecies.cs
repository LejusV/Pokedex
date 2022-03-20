using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Yamper Species to store common natural stats of all Yampers
	#region YamperSpecies
	public class YamperSpecies : PokemonSpecies
	{
#nullable enable
		private static YamperSpecies? _instance = null;
#nullable restore
        public static YamperSpecies Instance => _instance ?? (_instance = new YamperSpecies());

		#region YamperSpecies Constructor
		public YamperSpecies() : base(
			835,
			"Yamper",
			Electric.Instance,
			0.3,
			13.5,
			new PokemonStats(
				59, // HPs
				45, 50, // Attack & Defense
				40, 50, // Spacial Attack & Defense
				26 // Speed
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