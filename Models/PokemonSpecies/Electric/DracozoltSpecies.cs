using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dracozolt Species to store common natural stats of all Dracozolts
	#region DracozoltSpecies
	public class DracozoltSpecies : PokemonSpecies
	{
#nullable enable
		private static DracozoltSpecies? _instance = null;
#nullable restore
        public static DracozoltSpecies Instance => _instance ?? (_instance = new DracozoltSpecies());

		#region DracozoltSpecies Constructor
		public DracozoltSpecies() : base(
			880,
			"Dracozolt",
			Electric.Instance, Dragon.Instance,
			1.8,
			190.0,
			new PokemonStats(
				90, // HPs
				100, 90, // Attack & Defense
				80, 70, // Spacial Attack & Defense
				75 // Speed
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