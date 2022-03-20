using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wooloo Species to store common natural stats of all Wooloos
	#region WoolooSpecies
	public class WoolooSpecies : PokemonSpecies
	{
#nullable enable
		private static WoolooSpecies? _instance = null;
#nullable restore
        public static WoolooSpecies Instance => _instance ?? (_instance = new WoolooSpecies());

		#region WoolooSpecies Constructor
		public WoolooSpecies() : base(
			831,
			"Wooloo",
			Normal.Instance,
			0.6,
			6.0,
			new PokemonStats(
				42, // HPs
				40, 55, // Attack & Defense
				40, 45, // Spacial Attack & Defense
				48 // Speed
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