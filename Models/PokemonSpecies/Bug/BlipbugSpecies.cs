using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Blipbug Species to store common natural stats of all Blipbugs
	#region BlipbugSpecies
	public class BlipbugSpecies : PokemonSpecies
	{
#nullable enable
		private static BlipbugSpecies? _instance = null;
#nullable restore
        public static BlipbugSpecies Instance => _instance ?? (_instance = new BlipbugSpecies());

		#region BlipbugSpecies Constructor
		public BlipbugSpecies() : base(
			824,
			"Blipbug",
			Bug.Instance,
			0.4,
			8.0,
			new PokemonStats(
				25, // HPs
				20, 20, // Attack & Defense
				25, 45, // Spacial Attack & Defense
				45 // Speed
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