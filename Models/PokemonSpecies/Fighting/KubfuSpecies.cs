using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kubfu Species to store common natural stats of all Kubfus
	#region KubfuSpecies
	public class KubfuSpecies : PokemonSpecies
	{
#nullable enable
		private static KubfuSpecies? _instance = null;
#nullable restore
        public static KubfuSpecies Instance => _instance ?? (_instance = new KubfuSpecies());

		#region KubfuSpecies Constructor
		public KubfuSpecies() : base(
			891,
			"Kubfu",
			Fighting.Instance,
			0.6,
			12.0,
			new PokemonStats(
				60, // HPs
				90, 60, // Attack & Defense
				53, 50, // Spacial Attack & Defense
				72 // Speed
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