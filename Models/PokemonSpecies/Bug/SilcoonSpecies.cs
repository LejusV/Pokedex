using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Silcoon Species to store common natural stats of all Silcoons
	#region SilcoonSpecies
	public class SilcoonSpecies : PokemonSpecies
	{
#nullable enable
		private static SilcoonSpecies? _instance = null;
#nullable restore
        public static SilcoonSpecies Instance => _instance ?? (_instance = new SilcoonSpecies());

		#region SilcoonSpecies Constructor
		public SilcoonSpecies() : base(
			266,
			"Silcoon",
			Bug.Instance,
			0.6,
			10.0,
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