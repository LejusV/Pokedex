using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Centiskorch Species to store common natural stats of all Centiskorchs
	#region CentiskorchSpecies
	public class CentiskorchSpecies : PokemonSpecies
	{
#nullable enable
		private static CentiskorchSpecies? _instance = null;
#nullable restore
        public static CentiskorchSpecies Instance => _instance ?? (_instance = new CentiskorchSpecies());

		#region CentiskorchSpecies Constructor
		public CentiskorchSpecies() : base(
			851,
			"Centiskorch",
			Fire.Instance, Bug.Instance,
			3.0,
			120.0,
			new PokemonStats(
				100, // HPs
				115, 65, // Attack & Defense
				90, 90, // Spacial Attack & Defense
				65 // Speed
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