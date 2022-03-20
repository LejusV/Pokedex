using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Drednaw Species to store common natural stats of all Drednaws
	#region DrednawSpecies
	public class DrednawSpecies : PokemonSpecies
	{
#nullable enable
		private static DrednawSpecies? _instance = null;
#nullable restore
        public static DrednawSpecies Instance => _instance ?? (_instance = new DrednawSpecies());

		#region DrednawSpecies Constructor
		public DrednawSpecies() : base(
			834,
			"Drednaw",
			Water.Instance, Rock.Instance,
			1.0,
			115.5,
			new PokemonStats(
				90, // HPs
				115, 90, // Attack & Defense
				48, 68, // Spacial Attack & Defense
				74 // Speed
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