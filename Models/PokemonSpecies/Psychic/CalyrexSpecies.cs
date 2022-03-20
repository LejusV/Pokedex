using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Calyrex Species to store common natural stats of all Calyrexs
	#region CalyrexSpecies
	public class CalyrexSpecies : PokemonSpecies
	{
#nullable enable
		private static CalyrexSpecies? _instance = null;
#nullable restore
        public static CalyrexSpecies Instance => _instance ?? (_instance = new CalyrexSpecies());

		#region CalyrexSpecies Constructor
		public CalyrexSpecies() : base(
			898,
			"Calyrex",
			Psychic.Instance, Grass.Instance,
			1.1,
			7.7,
			new PokemonStats(
				100, // HPs
				80, 80, // Attack & Defense
				80, 80, // Spacial Attack & Defense
				80 // Speed
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