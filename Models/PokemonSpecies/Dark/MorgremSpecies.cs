using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Morgrem Species to store common natural stats of all Morgrems
	#region MorgremSpecies
	public class MorgremSpecies : PokemonSpecies
	{
#nullable enable
		private static MorgremSpecies? _instance = null;
#nullable restore
        public static MorgremSpecies Instance => _instance ?? (_instance = new MorgremSpecies());

		#region MorgremSpecies Constructor
		public MorgremSpecies() : base(
			860,
			"Morgrem",
			Dark.Instance, Fairy.Instance,
			0.8,
			12.5,
			new PokemonStats(
				65, // HPs
				60, 45, // Attack & Defense
				75, 55, // Spacial Attack & Defense
				70 // Speed
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