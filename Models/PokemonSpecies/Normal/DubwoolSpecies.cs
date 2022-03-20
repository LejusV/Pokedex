using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dubwool Species to store common natural stats of all Dubwools
	#region DubwoolSpecies
	public class DubwoolSpecies : PokemonSpecies
	{
#nullable enable
		private static DubwoolSpecies? _instance = null;
#nullable restore
        public static DubwoolSpecies Instance => _instance ?? (_instance = new DubwoolSpecies());

		#region DubwoolSpecies Constructor
		public DubwoolSpecies() : base(
			832,
			"Dubwool",
			Normal.Instance,
			1.3,
			43.0,
			new PokemonStats(
				72, // HPs
				80, 100, // Attack & Defense
				60, 90, // Spacial Attack & Defense
				88 // Speed
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