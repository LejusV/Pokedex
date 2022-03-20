using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Carkol Species to store common natural stats of all Carkols
	#region CarkolSpecies
	public class CarkolSpecies : PokemonSpecies
	{
#nullable enable
		private static CarkolSpecies? _instance = null;
#nullable restore
        public static CarkolSpecies Instance => _instance ?? (_instance = new CarkolSpecies());

		#region CarkolSpecies Constructor
		public CarkolSpecies() : base(
			838,
			"Carkol",
			Rock.Instance, Fire.Instance,
			1.1,
			78.0,
			new PokemonStats(
				80, // HPs
				60, 90, // Attack & Defense
				60, 70, // Spacial Attack & Defense
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