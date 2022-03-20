using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Weedle Species to store common natural stats of all Weedles
	#region WeedleSpecies
	public class WeedleSpecies : PokemonSpecies
	{
#nullable enable
		private static WeedleSpecies? _instance = null;
#nullable restore
        public static WeedleSpecies Instance => _instance ?? (_instance = new WeedleSpecies());

		#region WeedleSpecies Constructor
		public WeedleSpecies() : base(
			13,
			"Weedle",
			Bug.Instance, Poison.Instance,
			0.3,
			3.2,
			new PokemonStats(
				40, // HPs
				35, 30, // Attack & Defense
				20, 20, // Spacial Attack & Defense
				50 // Speed
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
				"Poison-Sting",
				"String-Shot",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion
}