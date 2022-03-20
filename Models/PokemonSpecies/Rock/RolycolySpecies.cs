using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rolycoly Species to store common natural stats of all Rolycolys
	#region RolycolySpecies
	public class RolycolySpecies : PokemonSpecies
	{
#nullable enable
		private static RolycolySpecies? _instance = null;
#nullable restore
        public static RolycolySpecies Instance => _instance ?? (_instance = new RolycolySpecies());

		#region RolycolySpecies Constructor
		public RolycolySpecies() : base(
			837,
			"Rolycoly",
			Rock.Instance,
			0.3,
			12.0,
			new PokemonStats(
				30, // HPs
				40, 50, // Attack & Defense
				40, 50, // Spacial Attack & Defense
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