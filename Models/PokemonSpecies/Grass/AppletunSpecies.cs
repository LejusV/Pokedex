using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Appletun Species to store common natural stats of all Appletuns
	#region AppletunSpecies
	public class AppletunSpecies : PokemonSpecies
	{
#nullable enable
		private static AppletunSpecies? _instance = null;
#nullable restore
        public static AppletunSpecies Instance => _instance ?? (_instance = new AppletunSpecies());

		#region AppletunSpecies Constructor
		public AppletunSpecies() : base(
			842,
			"Appletun",
			Grass.Instance, Dragon.Instance,
			0.4,
			13.0,
			new PokemonStats(
				110, // HPs
				85, 80, // Attack & Defense
				100, 80, // Spacial Attack & Defense
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