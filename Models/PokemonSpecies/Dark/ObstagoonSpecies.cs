using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Obstagoon Species to store common natural stats of all Obstagoons
	#region ObstagoonSpecies
	public class ObstagoonSpecies : PokemonSpecies
	{
#nullable enable
		private static ObstagoonSpecies? _instance = null;
#nullable restore
        public static ObstagoonSpecies Instance => _instance ?? (_instance = new ObstagoonSpecies());

		#region ObstagoonSpecies Constructor
		public ObstagoonSpecies() : base(
			862,
			"Obstagoon",
			Dark.Instance, Normal.Instance,
			1.6,
			46.0,
			new PokemonStats(
				93, // HPs
				90, 101, // Attack & Defense
				60, 81, // Spacial Attack & Defense
				95 // Speed
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