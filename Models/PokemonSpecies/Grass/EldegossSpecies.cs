using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Eldegoss Species to store common natural stats of all Eldegosss
	#region EldegossSpecies
	public class EldegossSpecies : PokemonSpecies
	{
#nullable enable
		private static EldegossSpecies? _instance = null;
#nullable restore
        public static EldegossSpecies Instance => _instance ?? (_instance = new EldegossSpecies());

		#region EldegossSpecies Constructor
		public EldegossSpecies() : base(
			830,
			"Eldegoss",
			Grass.Instance,
			0.5,
			2.5,
			new PokemonStats(
				60, // HPs
				50, 90, // Attack & Defense
				80, 120, // Spacial Attack & Defense
				60 // Speed
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