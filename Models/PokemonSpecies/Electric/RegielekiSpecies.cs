using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Regieleki Species to store common natural stats of all Regielekis
	#region RegielekiSpecies
	public class RegielekiSpecies : PokemonSpecies
	{
#nullable enable
		private static RegielekiSpecies? _instance = null;
#nullable restore
        public static RegielekiSpecies Instance => _instance ?? (_instance = new RegielekiSpecies());

		#region RegielekiSpecies Constructor
		public RegielekiSpecies() : base(
			894,
			"Regieleki",
			Electric.Instance,
			1.2,
			145.0,
			new PokemonStats(
				80, // HPs
				100, 50, // Attack & Defense
				100, 50, // Spacial Attack & Defense
				200 // Speed
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