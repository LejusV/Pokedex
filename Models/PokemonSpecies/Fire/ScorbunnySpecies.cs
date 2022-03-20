using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Scorbunny Species to store common natural stats of all Scorbunnys
	#region ScorbunnySpecies
	public class ScorbunnySpecies : PokemonSpecies
	{
#nullable enable
		private static ScorbunnySpecies? _instance = null;
#nullable restore
        public static ScorbunnySpecies Instance => _instance ?? (_instance = new ScorbunnySpecies());

		#region ScorbunnySpecies Constructor
		public ScorbunnySpecies() : base(
			813,
			"Scorbunny",
			Fire.Instance,
			0.3,
			4.5,
			new PokemonStats(
				50, // HPs
				71, 40, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				69 // Speed
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