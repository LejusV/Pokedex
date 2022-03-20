using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tynamo Species to store common natural stats of all Tynamos
	#region TynamoSpecies
	public class TynamoSpecies : PokemonSpecies
	{
#nullable enable
		private static TynamoSpecies? _instance = null;
#nullable restore
        public static TynamoSpecies Instance => _instance ?? (_instance = new TynamoSpecies());

		#region TynamoSpecies Constructor
		public TynamoSpecies() : base(
			602,
			"Tynamo",
			Electric.Instance,
			0.2,
			0.3,
			new PokemonStats(
				35, // HPs
				55, 40, // Attack & Defense
				45, 40, // Spacial Attack & Defense
				60 // Speed
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
				"Tackle",
				"Thunder-Wave",
				"Spark",
				"Magnet-Rise",
				"Charge-Beam"
			};
		}
		#endregion
	}
	#endregion
}