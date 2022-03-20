using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rillaboom Species to store common natural stats of all Rillabooms
	#region RillaboomSpecies
	public class RillaboomSpecies : PokemonSpecies
	{
#nullable enable
		private static RillaboomSpecies? _instance = null;
#nullable restore
        public static RillaboomSpecies Instance => _instance ?? (_instance = new RillaboomSpecies());

		#region RillaboomSpecies Constructor
		public RillaboomSpecies() : base(
			812,
			"Rillaboom",
			Grass.Instance,
			2.1,
			90.0,
			new PokemonStats(
				100, // HPs
				125, 90, // Attack & Defense
				60, 70, // Spacial Attack & Defense
				85 // Speed
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