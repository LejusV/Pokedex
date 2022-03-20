using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Polteageist Species to store common natural stats of all Polteageists
	#region PolteageistSpecies
	public class PolteageistSpecies : PokemonSpecies
	{
#nullable enable
		private static PolteageistSpecies? _instance = null;
#nullable restore
        public static PolteageistSpecies Instance => _instance ?? (_instance = new PolteageistSpecies());

		#region PolteageistSpecies Constructor
		public PolteageistSpecies() : base(
			855,
			"Polteageist",
			Ghost.Instance,
			0.2,
			0.4,
			new PokemonStats(
				60, // HPs
				65, 65, // Attack & Defense
				134, 114, // Spacial Attack & Defense
				70 // Speed
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