using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sandaconda Species to store common natural stats of all Sandacondas
	#region SandacondaSpecies
	public class SandacondaSpecies : PokemonSpecies
	{
#nullable enable
		private static SandacondaSpecies? _instance = null;
#nullable restore
        public static SandacondaSpecies Instance => _instance ?? (_instance = new SandacondaSpecies());

		#region SandacondaSpecies Constructor
		public SandacondaSpecies() : base(
			844,
			"Sandaconda",
			Ground.Instance,
			3.8,
			65.5,
			new PokemonStats(
				72, // HPs
				107, 125, // Attack & Defense
				65, 70, // Spacial Attack & Defense
				71 // Speed
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