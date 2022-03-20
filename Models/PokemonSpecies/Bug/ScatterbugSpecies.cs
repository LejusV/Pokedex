using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Scatterbug Species to store common natural stats of all Scatterbugs
	#region ScatterbugSpecies
	public class ScatterbugSpecies : PokemonSpecies
	{
#nullable enable
		private static ScatterbugSpecies? _instance = null;
#nullable restore
        public static ScatterbugSpecies Instance => _instance ?? (_instance = new ScatterbugSpecies());

		#region ScatterbugSpecies Constructor
		public ScatterbugSpecies() : base(
			664,
			"Scatterbug",
			Bug.Instance,
			0.3,
			2.5,
			new PokemonStats(
				38, // HPs
				35, 40, // Attack & Defense
				27, 25, // Spacial Attack & Defense
				35 // Speed
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
				"Poison-Powder",
				"Stun-Spore",
				"String-Shot",
				"Bug-Bite",
				"Rage-Powder"
			};
		}
		#endregion
	}
	#endregion
}