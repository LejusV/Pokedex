using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Skwovet Species to store common natural stats of all Skwovets
	#region SkwovetSpecies
	public class SkwovetSpecies : PokemonSpecies
	{
#nullable enable
		private static SkwovetSpecies? _instance = null;
#nullable restore
        public static SkwovetSpecies Instance => _instance ?? (_instance = new SkwovetSpecies());

		#region SkwovetSpecies Constructor
		public SkwovetSpecies() : base(
			819,
			"Skwovet",
			Normal.Instance,
			0.3,
			2.5,
			new PokemonStats(
				70, // HPs
				55, 55, // Attack & Defense
				35, 35, // Spacial Attack & Defense
				25 // Speed
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