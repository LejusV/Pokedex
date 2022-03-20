using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Arctovish Species to store common natural stats of all Arctovishs
	#region ArctovishSpecies
	public class ArctovishSpecies : PokemonSpecies
	{
#nullable enable
		private static ArctovishSpecies? _instance = null;
#nullable restore
        public static ArctovishSpecies Instance => _instance ?? (_instance = new ArctovishSpecies());

		#region ArctovishSpecies Constructor
		public ArctovishSpecies() : base(
			883,
			"Arctovish",
			Water.Instance, Ice.Instance,
			2.0,
			175.0,
			new PokemonStats(
				90, // HPs
				90, 100, // Attack & Defense
				80, 90, // Spacial Attack & Defense
				55 // Speed
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