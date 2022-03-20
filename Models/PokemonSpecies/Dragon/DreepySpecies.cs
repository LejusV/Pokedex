using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dreepy Species to store common natural stats of all Dreepys
	#region DreepySpecies
	public class DreepySpecies : PokemonSpecies
	{
#nullable enable
		private static DreepySpecies? _instance = null;
#nullable restore
        public static DreepySpecies Instance => _instance ?? (_instance = new DreepySpecies());

		#region DreepySpecies Constructor
		public DreepySpecies() : base(
			885,
			"Dreepy",
			Dragon.Instance, Ghost.Instance,
			0.5,
			2.0,
			new PokemonStats(
				28, // HPs
				60, 30, // Attack & Defense
				40, 30, // Spacial Attack & Defense
				82 // Speed
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