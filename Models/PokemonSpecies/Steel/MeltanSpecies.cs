using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Meltan Species to store common natural stats of all Meltans
	#region MeltanSpecies
	public class MeltanSpecies : PokemonSpecies
	{
#nullable enable
		private static MeltanSpecies? _instance = null;
#nullable restore
        public static MeltanSpecies Instance => _instance ?? (_instance = new MeltanSpecies());

		#region MeltanSpecies Constructor
		public MeltanSpecies() : base(
			808,
			"Meltan",
			Steel.Instance,
			0.2,
			8.0,
			new PokemonStats(
				46, // HPs
				65, 65, // Attack & Defense
				55, 35, // Spacial Attack & Defense
				34 // Speed
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