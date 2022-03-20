using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Applin Species to store common natural stats of all Applins
	#region ApplinSpecies
	public class ApplinSpecies : PokemonSpecies
	{
#nullable enable
		private static ApplinSpecies? _instance = null;
#nullable restore
        public static ApplinSpecies Instance => _instance ?? (_instance = new ApplinSpecies());

		#region ApplinSpecies Constructor
		public ApplinSpecies() : base(
			840,
			"Applin",
			Grass.Instance, Dragon.Instance,
			0.2,
			0.5,
			new PokemonStats(
				40, // HPs
				40, 80, // Attack & Defense
				40, 40, // Spacial Attack & Defense
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