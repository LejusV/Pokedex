using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Drizzile Species to store common natural stats of all Drizziles
	#region DrizzileSpecies
	public class DrizzileSpecies : PokemonSpecies
	{
#nullable enable
		private static DrizzileSpecies? _instance = null;
#nullable restore
        public static DrizzileSpecies Instance => _instance ?? (_instance = new DrizzileSpecies());

		#region DrizzileSpecies Constructor
		public DrizzileSpecies() : base(
			817,
			"Drizzile",
			Water.Instance,
			0.7,
			11.5,
			new PokemonStats(
				65, // HPs
				60, 55, // Attack & Defense
				95, 55, // Spacial Attack & Defense
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