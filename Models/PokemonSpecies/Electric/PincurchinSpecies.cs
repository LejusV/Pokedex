using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pincurchin Species to store common natural stats of all Pincurchins
	#region PincurchinSpecies
	public class PincurchinSpecies : PokemonSpecies
	{
#nullable enable
		private static PincurchinSpecies? _instance = null;
#nullable restore
        public static PincurchinSpecies Instance => _instance ?? (_instance = new PincurchinSpecies());

		#region PincurchinSpecies Constructor
		public PincurchinSpecies() : base(
			871,
			"Pincurchin",
			Electric.Instance,
			0.3,
			1.0,
			new PokemonStats(
				48, // HPs
				101, 95, // Attack & Defense
				91, 85, // Spacial Attack & Defense
				15 // Speed
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