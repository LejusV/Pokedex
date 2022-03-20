using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Burmy Species to store common natural stats of all Burmys
	#region BurmySpecies
	public class BurmySpecies : PokemonSpecies
	{
#nullable enable
		private static BurmySpecies? _instance = null;
#nullable restore
        public static BurmySpecies Instance => _instance ?? (_instance = new BurmySpecies());

		#region BurmySpecies Constructor
		public BurmySpecies() : base(
			412,
			"Burmy",
			Bug.Instance,
			0.2,
			3.4,
			new PokemonStats(
				40, // HPs
				29, 45, // Attack & Defense
				29, 45, // Spacial Attack & Defense
				36 // Speed
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
				"Protect",
				"Hidden-Power",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion
}