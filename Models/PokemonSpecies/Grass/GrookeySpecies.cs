using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Grookey Species to store common natural stats of all Grookeys
	#region GrookeySpecies
	public class GrookeySpecies : PokemonSpecies
	{
#nullable enable
		private static GrookeySpecies? _instance = null;
#nullable restore
        public static GrookeySpecies Instance => _instance ?? (_instance = new GrookeySpecies());

		#region GrookeySpecies Constructor
		public GrookeySpecies() : base(
			810,
			"Grookey",
			Grass.Instance,
			0.3,
			5.0,
			new PokemonStats(
				50, // HPs
				65, 50, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				65 // Speed
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