using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cosmog Species to store common natural stats of all Cosmogs
	#region CosmogSpecies
	public class CosmogSpecies : PokemonSpecies
	{
#nullable enable
		private static CosmogSpecies? _instance = null;
#nullable restore
        public static CosmogSpecies Instance => _instance ?? (_instance = new CosmogSpecies());

		#region CosmogSpecies Constructor
		public CosmogSpecies() : base(
			789,
			"Cosmog",
			Psychic.Instance,
			0.2,
			0.1,
			new PokemonStats(
				43, // HPs
				29, 31, // Attack & Defense
				29, 31, // Spacial Attack & Defense
				37 // Speed
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
				"Teleport",
				"Splash"
			};
		}
		#endregion
	}
	#endregion
}