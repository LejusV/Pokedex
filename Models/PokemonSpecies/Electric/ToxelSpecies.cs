using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Toxel Species to store common natural stats of all Toxels
	#region ToxelSpecies
	public class ToxelSpecies : PokemonSpecies
	{
#nullable enable
		private static ToxelSpecies? _instance = null;
#nullable restore
        public static ToxelSpecies Instance => _instance ?? (_instance = new ToxelSpecies());

		#region ToxelSpecies Constructor
		public ToxelSpecies() : base(
			848,
			"Toxel",
			Electric.Instance, Poison.Instance,
			0.4,
			11.0,
			new PokemonStats(
				40, // HPs
				38, 35, // Attack & Defense
				54, 35, // Spacial Attack & Defense
				40 // Speed
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