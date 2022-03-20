using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zarude Species to store common natural stats of all Zarudes
	#region ZarudeSpecies
	public class ZarudeSpecies : PokemonSpecies
	{
#nullable enable
		private static ZarudeSpecies? _instance = null;
#nullable restore
        public static ZarudeSpecies Instance => _instance ?? (_instance = new ZarudeSpecies());

		#region ZarudeSpecies Constructor
		public ZarudeSpecies() : base(
			893,
			"Zarude",
			Dark.Instance, Grass.Instance,
			1.8,
			70.0,
			new PokemonStats(
				105, // HPs
				120, 105, // Attack & Defense
				70, 95, // Spacial Attack & Defense
				105 // Speed
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