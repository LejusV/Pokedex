using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cascoon Species to store common natural stats of all Cascoons
	#region CascoonSpecies
	public class CascoonSpecies : PokemonSpecies
	{
#nullable enable
		private static CascoonSpecies? _instance = null;
#nullable restore
        public static CascoonSpecies Instance => _instance ?? (_instance = new CascoonSpecies());

		#region CascoonSpecies Constructor
		public CascoonSpecies() : base(
			268,
			"Cascoon",
			Bug.Instance,
			0.7,
			11.5,
			new PokemonStats(
				50, // HPs
				35, 55, // Attack & Defense
				25, 25, // Spacial Attack & Defense
				15 // Speed
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
				"String-Shot",
				"Harden",
				"Iron-Defense",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion
}