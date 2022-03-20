using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Copperajah Species to store common natural stats of all Copperajahs
	#region CopperajahSpecies
	public class CopperajahSpecies : PokemonSpecies
	{
#nullable enable
		private static CopperajahSpecies? _instance = null;
#nullable restore
        public static CopperajahSpecies Instance => _instance ?? (_instance = new CopperajahSpecies());

		#region CopperajahSpecies Constructor
		public CopperajahSpecies() : base(
			879,
			"Copperajah",
			Steel.Instance,
			3.0,
			650.0,
			new PokemonStats(
				122, // HPs
				130, 69, // Attack & Defense
				80, 69, // Spacial Attack & Defense
				30 // Speed
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