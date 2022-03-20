using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wurmple Species to store common natural stats of all Wurmples
	#region WurmpleSpecies
	public class WurmpleSpecies : PokemonSpecies
	{
#nullable enable
		private static WurmpleSpecies? _instance = null;
#nullable restore
        public static WurmpleSpecies Instance => _instance ?? (_instance = new WurmpleSpecies());

		#region WurmpleSpecies Constructor
		public WurmpleSpecies() : base(
			265,
			"Wurmple",
			Bug.Instance,
			0.3,
			3.6,
			new PokemonStats(
				45, // HPs
				45, 35, // Attack & Defense
				20, 30, // Spacial Attack & Defense
				20 // Speed
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
				"Poison-Sting",
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