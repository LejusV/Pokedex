using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sinistea Species to store common natural stats of all Sinisteas
	#region SinisteaSpecies
	public class SinisteaSpecies : PokemonSpecies
	{
#nullable enable
		private static SinisteaSpecies? _instance = null;
#nullable restore
        public static SinisteaSpecies Instance => _instance ?? (_instance = new SinisteaSpecies());

		#region SinisteaSpecies Constructor
		public SinisteaSpecies() : base(
			854,
			"Sinistea",
			Ghost.Instance,
			0.1,
			0.2,
			new PokemonStats(
				40, // HPs
				45, 45, // Attack & Defense
				74, 54, // Spacial Attack & Defense
				50 // Speed
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