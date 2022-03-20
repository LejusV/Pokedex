using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hatenna Species to store common natural stats of all Hatennas
	#region HatennaSpecies
	public class HatennaSpecies : PokemonSpecies
	{
#nullable enable
		private static HatennaSpecies? _instance = null;
#nullable restore
        public static HatennaSpecies Instance => _instance ?? (_instance = new HatennaSpecies());

		#region HatennaSpecies Constructor
		public HatennaSpecies() : base(
			856,
			"Hatenna",
			Psychic.Instance,
			0.4,
			3.4,
			new PokemonStats(
				42, // HPs
				30, 45, // Attack & Defense
				56, 53, // Spacial Attack & Defense
				39 // Speed
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