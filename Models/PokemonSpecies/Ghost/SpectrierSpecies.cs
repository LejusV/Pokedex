using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Spectrier Species to store common natural stats of all Spectriers
	#region SpectrierSpecies
	public class SpectrierSpecies : PokemonSpecies
	{
#nullable enable
		private static SpectrierSpecies? _instance = null;
#nullable restore
        public static SpectrierSpecies Instance => _instance ?? (_instance = new SpectrierSpecies());

		#region SpectrierSpecies Constructor
		public SpectrierSpecies() : base(
			897,
			"Spectrier",
			Ghost.Instance,
			2.0,
			44.5,
			new PokemonStats(
				100, // HPs
				65, 60, // Attack & Defense
				145, 80, // Spacial Attack & Defense
				130 // Speed
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