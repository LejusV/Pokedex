using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Toxtricity-Amped Species to store common natural stats of all Toxtricity-Ampeds
	#region Toxtricity-AmpedSpecies
	public class ToxtricityAmpedSpecies : PokemonSpecies
	{
#nullable enable
		private static ToxtricityAmpedSpecies? _instance = null;
#nullable restore
        public static ToxtricityAmpedSpecies Instance => _instance ?? (_instance = new ToxtricityAmpedSpecies());

		#region Toxtricity-AmpedSpecies Constructor
		public ToxtricityAmpedSpecies() : base(
			849,
			"Toxtricity-Amped",
			Electric.Instance, Poison.Instance,
			1.6,
			40.0,
			new PokemonStats(
				75, // HPs
				98, 70, // Attack & Defense
				114, 70, // Spacial Attack & Defense
				75 // Speed
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