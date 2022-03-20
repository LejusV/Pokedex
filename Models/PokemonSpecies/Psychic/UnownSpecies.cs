using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Unown Species to store common natural stats of all Unowns
	#region UnownSpecies
	public class UnownSpecies : PokemonSpecies
	{
#nullable enable
		private static UnownSpecies? _instance = null;
#nullable restore
        public static UnownSpecies Instance => _instance ?? (_instance = new UnownSpecies());

		#region UnownSpecies Constructor
		public UnownSpecies() : base(
			201,
			"Unown",
			Psychic.Instance,
			0.5,
			5.0,
			new PokemonStats(
				48, // HPs
				72, 48, // Attack & Defense
				72, 48, // Spacial Attack & Defense
				48 // Speed
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
				"Hidden-Power"
			};
		}
		#endregion
	}
	#endregion
}