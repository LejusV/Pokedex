using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Regidrago Species to store common natural stats of all Regidragos
	#region RegidragoSpecies
	public class RegidragoSpecies : PokemonSpecies
	{
#nullable enable
		private static RegidragoSpecies? _instance = null;
#nullable restore
        public static RegidragoSpecies Instance => _instance ?? (_instance = new RegidragoSpecies());

		#region RegidragoSpecies Constructor
		public RegidragoSpecies() : base(
			895,
			"Regidrago",
			Dragon.Instance,
			2.1,
			200.0,
			new PokemonStats(
				200, // HPs
				100, 50, // Attack & Defense
				100, 50, // Spacial Attack & Defense
				80 // Speed
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