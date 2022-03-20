using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cinderace Species to store common natural stats of all Cinderaces
	#region CinderaceSpecies
	public class CinderaceSpecies : PokemonSpecies
	{
#nullable enable
		private static CinderaceSpecies? _instance = null;
#nullable restore
        public static CinderaceSpecies Instance => _instance ?? (_instance = new CinderaceSpecies());

		#region CinderaceSpecies Constructor
		public CinderaceSpecies() : base(
			815,
			"Cinderace",
			Fire.Instance,
			1.4,
			33.0,
			new PokemonStats(
				80, // HPs
				116, 75, // Attack & Defense
				65, 75, // Spacial Attack & Defense
				119 // Speed
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