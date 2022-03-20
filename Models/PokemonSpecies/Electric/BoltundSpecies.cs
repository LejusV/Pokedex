using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Boltund Species to store common natural stats of all Boltunds
	#region BoltundSpecies
	public class BoltundSpecies : PokemonSpecies
	{
#nullable enable
		private static BoltundSpecies? _instance = null;
#nullable restore
        public static BoltundSpecies Instance => _instance ?? (_instance = new BoltundSpecies());

		#region BoltundSpecies Constructor
		public BoltundSpecies() : base(
			836,
			"Boltund",
			Electric.Instance,
			1.0,
			34.0,
			new PokemonStats(
				69, // HPs
				90, 60, // Attack & Defense
				90, 60, // Spacial Attack & Defense
				121 // Speed
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