using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Grimmsnarl Species to store common natural stats of all Grimmsnarls
	#region GrimmsnarlSpecies
	public class GrimmsnarlSpecies : PokemonSpecies
	{
#nullable enable
		private static GrimmsnarlSpecies? _instance = null;
#nullable restore
        public static GrimmsnarlSpecies Instance => _instance ?? (_instance = new GrimmsnarlSpecies());

		#region GrimmsnarlSpecies Constructor
		public GrimmsnarlSpecies() : base(
			861,
			"Grimmsnarl",
			Dark.Instance, Fairy.Instance,
			1.5,
			61.0,
			new PokemonStats(
				95, // HPs
				120, 65, // Attack & Defense
				95, 75, // Spacial Attack & Defense
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