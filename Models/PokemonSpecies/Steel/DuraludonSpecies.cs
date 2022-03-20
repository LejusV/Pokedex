using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Duraludon Species to store common natural stats of all Duraludons
	#region DuraludonSpecies
	public class DuraludonSpecies : PokemonSpecies
	{
#nullable enable
		private static DuraludonSpecies? _instance = null;
#nullable restore
        public static DuraludonSpecies Instance => _instance ?? (_instance = new DuraludonSpecies());

		#region DuraludonSpecies Constructor
		public DuraludonSpecies() : base(
			884,
			"Duraludon",
			Steel.Instance, Dragon.Instance,
			1.8,
			40.0,
			new PokemonStats(
				70, // HPs
				95, 115, // Attack & Defense
				120, 50, // Spacial Attack & Defense
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