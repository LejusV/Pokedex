using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Caterpie Species to store common natural stats of all Caterpies
	#region CaterpieSpecies
	public class CaterpieSpecies : PokemonSpecies
	{
#nullable enable
		private static CaterpieSpecies? _instance = null;
#nullable restore
        public static CaterpieSpecies Instance => _instance ?? (_instance = new CaterpieSpecies());

		#region CaterpieSpecies Constructor
		public CaterpieSpecies() : base(
			10,
			"Caterpie",
			Bug.Instance,
			0.3,
			2.9,
			new PokemonStats(
				45, // HPs
				30, 35, // Attack & Defense
				20, 20, // Spacial Attack & Defense
				45 // Speed
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
				"Tackle",
				"String-Shot",
				"Snore",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion
}