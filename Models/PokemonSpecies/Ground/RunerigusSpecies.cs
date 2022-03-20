using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Runerigus Species to store common natural stats of all Runeriguss
	#region RunerigusSpecies
	public class RunerigusSpecies : PokemonSpecies
	{
#nullable enable
		private static RunerigusSpecies? _instance = null;
#nullable restore
        public static RunerigusSpecies Instance => _instance ?? (_instance = new RunerigusSpecies());

		#region RunerigusSpecies Constructor
		public RunerigusSpecies() : base(
			867,
			"Runerigus",
			Ground.Instance, Ghost.Instance,
			1.6,
			66.6,
			new PokemonStats(
				58, // HPs
				95, 145, // Attack & Defense
				50, 105, // Spacial Attack & Defense
				30 // Speed
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