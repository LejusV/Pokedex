using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Orbeetle Species to store common natural stats of all Orbeetles
	#region OrbeetleSpecies
	public class OrbeetleSpecies : PokemonSpecies
	{
#nullable enable
		private static OrbeetleSpecies? _instance = null;
#nullable restore
        public static OrbeetleSpecies Instance => _instance ?? (_instance = new OrbeetleSpecies());

		#region OrbeetleSpecies Constructor
		public OrbeetleSpecies() : base(
			826,
			"Orbeetle",
			Bug.Instance, Psychic.Instance,
			0.4,
			40.8,
			new PokemonStats(
				60, // HPs
				45, 110, // Attack & Defense
				80, 120, // Spacial Attack & Defense
				90 // Speed
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