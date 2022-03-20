using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Drakloak Species to store common natural stats of all Drakloaks
	#region DrakloakSpecies
	public class DrakloakSpecies : PokemonSpecies
	{
#nullable enable
		private static DrakloakSpecies? _instance = null;
#nullable restore
        public static DrakloakSpecies Instance => _instance ?? (_instance = new DrakloakSpecies());

		#region DrakloakSpecies Constructor
		public DrakloakSpecies() : base(
			886,
			"Drakloak",
			Dragon.Instance, Ghost.Instance,
			1.4,
			11.0,
			new PokemonStats(
				68, // HPs
				80, 50, // Attack & Defense
				60, 50, // Spacial Attack & Defense
				102 // Speed
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