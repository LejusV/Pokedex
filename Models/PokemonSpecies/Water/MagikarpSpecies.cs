using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Magikarp Species to store common natural stats of all Magikarps
	#region MagikarpSpecies
	public class MagikarpSpecies : PokemonSpecies
	{
#nullable enable
		private static MagikarpSpecies? _instance = null;
#nullable restore
        public static MagikarpSpecies Instance => _instance ?? (_instance = new MagikarpSpecies());

		#region MagikarpSpecies Constructor
		public MagikarpSpecies() : base(
			129,
			"Magikarp",
			Water.Instance,
			0.9,
			10.0,
			new PokemonStats(
				20, // HPs
				10, 55, // Attack & Defense
				15, 20, // Spacial Attack & Defense
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
				"Tackle",
				"Splash",
				"Flail",
				"Bounce"
			};
		}
		#endregion
	}
	#endregion
}