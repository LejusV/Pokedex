using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Snom Species to store common natural stats of all Snoms
	#region SnomSpecies
	public class SnomSpecies : PokemonSpecies
	{
#nullable enable
		private static SnomSpecies? _instance = null;
#nullable restore
        public static SnomSpecies Instance => _instance ?? (_instance = new SnomSpecies());

		#region SnomSpecies Constructor
		public SnomSpecies() : base(
			872,
			"Snom",
			Ice.Instance, Bug.Instance,
			0.3,
			3.8,
			new PokemonStats(
				30, // HPs
				25, 35, // Attack & Defense
				45, 30, // Spacial Attack & Defense
				20 // Speed
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