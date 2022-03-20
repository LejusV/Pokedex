using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Flapple Species to store common natural stats of all Flapples
	#region FlappleSpecies
	public class FlappleSpecies : PokemonSpecies
	{
#nullable enable
		private static FlappleSpecies? _instance = null;
#nullable restore
        public static FlappleSpecies Instance => _instance ?? (_instance = new FlappleSpecies());

		#region FlappleSpecies Constructor
		public FlappleSpecies() : base(
			841,
			"Flapple",
			Grass.Instance, Dragon.Instance,
			0.3,
			1.0,
			new PokemonStats(
				70, // HPs
				110, 80, // Attack & Defense
				95, 60, // Spacial Attack & Defense
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