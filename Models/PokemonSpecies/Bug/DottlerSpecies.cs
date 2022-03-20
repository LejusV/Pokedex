using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dottler Species to store common natural stats of all Dottlers
	#region DottlerSpecies
	public class DottlerSpecies : PokemonSpecies
	{
#nullable enable
		private static DottlerSpecies? _instance = null;
#nullable restore
        public static DottlerSpecies Instance => _instance ?? (_instance = new DottlerSpecies());

		#region DottlerSpecies Constructor
		public DottlerSpecies() : base(
			825,
			"Dottler",
			Bug.Instance, Psychic.Instance,
			0.4,
			19.5,
			new PokemonStats(
				50, // HPs
				35, 80, // Attack & Defense
				50, 90, // Spacial Attack & Defense
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