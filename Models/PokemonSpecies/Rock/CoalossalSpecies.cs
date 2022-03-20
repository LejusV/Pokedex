using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Coalossal Species to store common natural stats of all Coalossals
	#region CoalossalSpecies
	public class CoalossalSpecies : PokemonSpecies
	{
#nullable enable
		private static CoalossalSpecies? _instance = null;
#nullable restore
        public static CoalossalSpecies Instance => _instance ?? (_instance = new CoalossalSpecies());

		#region CoalossalSpecies Constructor
		public CoalossalSpecies() : base(
			839,
			"Coalossal",
			Rock.Instance, Fire.Instance,
			2.8,
			310.5,
			new PokemonStats(
				110, // HPs
				80, 120, // Attack & Defense
				80, 90, // Spacial Attack & Defense
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