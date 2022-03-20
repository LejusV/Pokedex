using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sobble Species to store common natural stats of all Sobbles
	#region SobbleSpecies
	public class SobbleSpecies : PokemonSpecies
	{
#nullable enable
		private static SobbleSpecies? _instance = null;
#nullable restore
        public static SobbleSpecies Instance => _instance ?? (_instance = new SobbleSpecies());

		#region SobbleSpecies Constructor
		public SobbleSpecies() : base(
			816,
			"Sobble",
			Water.Instance,
			0.3,
			4.0,
			new PokemonStats(
				50, // HPs
				40, 40, // Attack & Defense
				70, 40, // Spacial Attack & Defense
				70 // Speed
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