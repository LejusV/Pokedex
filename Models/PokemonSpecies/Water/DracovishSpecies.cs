using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dracovish Species to store common natural stats of all Dracovishs
	#region DracovishSpecies
	public class DracovishSpecies : PokemonSpecies
	{
#nullable enable
		private static DracovishSpecies? _instance = null;
#nullable restore
        public static DracovishSpecies Instance => _instance ?? (_instance = new DracovishSpecies());

		#region DracovishSpecies Constructor
		public DracovishSpecies() : base(
			882,
			"Dracovish",
			Water.Instance, Dragon.Instance,
			2.3,
			215.0,
			new PokemonStats(
				90, // HPs
				90, 100, // Attack & Defense
				70, 80, // Spacial Attack & Defense
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