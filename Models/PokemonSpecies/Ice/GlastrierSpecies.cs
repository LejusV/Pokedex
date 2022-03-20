using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Glastrier Species to store common natural stats of all Glastriers
	#region GlastrierSpecies
	public class GlastrierSpecies : PokemonSpecies
	{
#nullable enable
		private static GlastrierSpecies? _instance = null;
#nullable restore
        public static GlastrierSpecies Instance => _instance ?? (_instance = new GlastrierSpecies());

		#region GlastrierSpecies Constructor
		public GlastrierSpecies() : base(
			896,
			"Glastrier",
			Ice.Instance,
			2.2,
			800.0,
			new PokemonStats(
				100, // HPs
				145, 130, // Attack & Defense
				65, 110, // Spacial Attack & Defense
				30 // Speed
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