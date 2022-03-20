using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wynaut Species to store common natural stats of all Wynauts
	#region WynautSpecies
	public class WynautSpecies : PokemonSpecies
	{
#nullable enable
		private static WynautSpecies? _instance = null;
#nullable restore
        public static WynautSpecies Instance => _instance ?? (_instance = new WynautSpecies());

		#region WynautSpecies Constructor
		public WynautSpecies() : base(
			360,
			"Wynaut",
			Psychic.Instance,
			0.6,
			14.0,
			new PokemonStats(
				95, // HPs
				23, 48, // Attack & Defense
				23, 48, // Spacial Attack & Defense
				23 // Speed
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
				"Counter",
				"Splash",
				"Destiny-Bond",
				"Charm",
				"Safeguard",
				"Encore",
				"Mirror-Coat"
			};
		}
		#endregion
	}
	#endregion
}