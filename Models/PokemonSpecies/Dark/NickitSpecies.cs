using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nickit Species to store common natural stats of all Nickits
	#region NickitSpecies
	public class NickitSpecies : PokemonSpecies
	{
#nullable enable
		private static NickitSpecies? _instance = null;
#nullable restore
        public static NickitSpecies Instance => _instance ?? (_instance = new NickitSpecies());

		#region NickitSpecies Constructor
		public NickitSpecies() : base(
			827,
			"Nickit",
			Dark.Instance,
			0.6,
			8.9,
			new PokemonStats(
				40, // HPs
				28, 28, // Attack & Defense
				47, 52, // Spacial Attack & Defense
				50 // Speed
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