using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Arrokuda Species to store common natural stats of all Arrokudas
	#region ArrokudaSpecies
	public class ArrokudaSpecies : PokemonSpecies
	{
#nullable enable
		private static ArrokudaSpecies? _instance = null;
#nullable restore
        public static ArrokudaSpecies Instance => _instance ?? (_instance = new ArrokudaSpecies());

		#region ArrokudaSpecies Constructor
		public ArrokudaSpecies() : base(
			846,
			"Arrokuda",
			Water.Instance,
			0.5,
			1.0,
			new PokemonStats(
				41, // HPs
				63, 40, // Attack & Defense
				40, 30, // Spacial Attack & Defense
				66 // Speed
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