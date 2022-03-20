using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sizzlipede Species to store common natural stats of all Sizzlipedes
	#region SizzlipedeSpecies
	public class SizzlipedeSpecies : PokemonSpecies
	{
#nullable enable
		private static SizzlipedeSpecies? _instance = null;
#nullable restore
        public static SizzlipedeSpecies Instance => _instance ?? (_instance = new SizzlipedeSpecies());

		#region SizzlipedeSpecies Constructor
		public SizzlipedeSpecies() : base(
			850,
			"Sizzlipede",
			Fire.Instance, Bug.Instance,
			0.7,
			1.0,
			new PokemonStats(
				50, // HPs
				65, 45, // Attack & Defense
				50, 50, // Spacial Attack & Defense
				45 // Speed
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