using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chewtle Species to store common natural stats of all Chewtles
	#region ChewtleSpecies
	public class ChewtleSpecies : PokemonSpecies
	{
#nullable enable
		private static ChewtleSpecies? _instance = null;
#nullable restore
        public static ChewtleSpecies Instance => _instance ?? (_instance = new ChewtleSpecies());

		#region ChewtleSpecies Constructor
		public ChewtleSpecies() : base(
			833,
			"Chewtle",
			Water.Instance,
			0.3,
			8.5,
			new PokemonStats(
				50, // HPs
				64, 50, // Attack & Defense
				38, 38, // Spacial Attack & Defense
				44 // Speed
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