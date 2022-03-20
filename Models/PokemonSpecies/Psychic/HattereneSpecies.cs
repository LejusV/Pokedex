using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hatterene Species to store common natural stats of all Hatterenes
	#region HattereneSpecies
	public class HattereneSpecies : PokemonSpecies
	{
#nullable enable
		private static HattereneSpecies? _instance = null;
#nullable restore
        public static HattereneSpecies Instance => _instance ?? (_instance = new HattereneSpecies());

		#region HattereneSpecies Constructor
		public HattereneSpecies() : base(
			858,
			"Hatterene",
			Psychic.Instance, Fairy.Instance,
			2.1,
			5.1,
			new PokemonStats(
				57, // HPs
				90, 95, // Attack & Defense
				136, 103, // Spacial Attack & Defense
				29 // Speed
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