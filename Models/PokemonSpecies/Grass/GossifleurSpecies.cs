using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gossifleur Species to store common natural stats of all Gossifleurs
	#region GossifleurSpecies
	public class GossifleurSpecies : PokemonSpecies
	{
#nullable enable
		private static GossifleurSpecies? _instance = null;
#nullable restore
        public static GossifleurSpecies Instance => _instance ?? (_instance = new GossifleurSpecies());

		#region GossifleurSpecies Constructor
		public GossifleurSpecies() : base(
			829,
			"Gossifleur",
			Grass.Instance,
			0.4,
			2.2,
			new PokemonStats(
				40, // HPs
				40, 60, // Attack & Defense
				40, 60, // Spacial Attack & Defense
				10 // Speed
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