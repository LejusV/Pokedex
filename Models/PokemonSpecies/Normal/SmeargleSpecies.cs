using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Smeargle Species to store common natural stats of all Smeargles
	#region SmeargleSpecies
	public class SmeargleSpecies : PokemonSpecies
	{
#nullable enable
		private static SmeargleSpecies? _instance = null;
#nullable restore
        public static SmeargleSpecies Instance => _instance ?? (_instance = new SmeargleSpecies());

		#region SmeargleSpecies Constructor
		public SmeargleSpecies() : base(
			235,
			"Smeargle",
			Normal.Instance,
			1.2,
			58.0,
			new PokemonStats(
				55, // HPs
				20, 35, // Attack & Defense
				20, 45, // Spacial Attack & Defense
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
				"Sketch"
			};
		}
		#endregion
	}
	#endregion
}