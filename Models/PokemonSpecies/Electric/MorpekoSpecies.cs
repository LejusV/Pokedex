using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Morpeko Species to store common natural stats of all Morpekos
	#region MorpekoSpecies
	public class MorpekoSpecies : PokemonSpecies
	{
#nullable enable
		private static MorpekoSpecies? _instance = null;
#nullable restore
        public static MorpekoSpecies Instance => _instance ?? (_instance = new MorpekoSpecies());

		#region MorpekoSpecies Constructor
		public MorpekoSpecies() : base(
			877,
			"Morpeko",
			Electric.Instance, Dark.Instance,
			0.3,
			3.0,
			new PokemonStats(
				58, // HPs
				95, 58, // Attack & Defense
				70, 58, // Spacial Attack & Defense
				97 // Speed
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