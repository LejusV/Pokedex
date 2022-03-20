using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Inteleon Species to store common natural stats of all Inteleons
	#region InteleonSpecies
	public class InteleonSpecies : PokemonSpecies
	{
#nullable enable
		private static InteleonSpecies? _instance = null;
#nullable restore
        public static InteleonSpecies Instance => _instance ?? (_instance = new InteleonSpecies());

		#region InteleonSpecies Constructor
		public InteleonSpecies() : base(
			818,
			"Inteleon",
			Water.Instance,
			1.9,
			45.2,
			new PokemonStats(
				70, // HPs
				85, 65, // Attack & Defense
				125, 65, // Spacial Attack & Defense
				120 // Speed
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