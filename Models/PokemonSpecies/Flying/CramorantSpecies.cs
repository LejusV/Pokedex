using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cramorant Species to store common natural stats of all Cramorants
	#region CramorantSpecies
	public class CramorantSpecies : PokemonSpecies
	{
#nullable enable
		private static CramorantSpecies? _instance = null;
#nullable restore
        public static CramorantSpecies Instance => _instance ?? (_instance = new CramorantSpecies());

		#region CramorantSpecies Constructor
		public CramorantSpecies() : base(
			845,
			"Cramorant",
			Flying.Instance, Water.Instance,
			0.8,
			18.0,
			new PokemonStats(
				70, // HPs
				85, 55, // Attack & Defense
				85, 95, // Spacial Attack & Defense
				85 // Speed
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