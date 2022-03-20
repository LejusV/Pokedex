using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Silicobra Species to store common natural stats of all Silicobras
	#region SilicobraSpecies
	public class SilicobraSpecies : PokemonSpecies
	{
#nullable enable
		private static SilicobraSpecies? _instance = null;
#nullable restore
        public static SilicobraSpecies Instance => _instance ?? (_instance = new SilicobraSpecies());

		#region SilicobraSpecies Constructor
		public SilicobraSpecies() : base(
			843,
			"Silicobra",
			Ground.Instance,
			2.2,
			7.6,
			new PokemonStats(
				52, // HPs
				57, 75, // Attack & Defense
				35, 50, // Spacial Attack & Defense
				46 // Speed
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