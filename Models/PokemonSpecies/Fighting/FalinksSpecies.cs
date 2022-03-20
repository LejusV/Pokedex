using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Falinks Species to store common natural stats of all Falinkss
	#region FalinksSpecies
	public class FalinksSpecies : PokemonSpecies
	{
#nullable enable
		private static FalinksSpecies? _instance = null;
#nullable restore
        public static FalinksSpecies Instance => _instance ?? (_instance = new FalinksSpecies());

		#region FalinksSpecies Constructor
		public FalinksSpecies() : base(
			870,
			"Falinks",
			Fighting.Instance,
			3.0,
			62.0,
			new PokemonStats(
				65, // HPs
				100, 100, // Attack & Defense
				70, 60, // Spacial Attack & Defense
				75 // Speed
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