using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Eternatus Species to store common natural stats of all Eternatuss
	#region EternatusSpecies
	public class EternatusSpecies : PokemonSpecies
	{
#nullable enable
		private static EternatusSpecies? _instance = null;
#nullable restore
        public static EternatusSpecies Instance => _instance ?? (_instance = new EternatusSpecies());

		#region EternatusSpecies Constructor
		public EternatusSpecies() : base(
			890,
			"Eternatus",
			Poison.Instance, Dragon.Instance,
			20.0,
			950.0,
			new PokemonStats(
				140, // HPs
				85, 95, // Attack & Defense
				145, 95, // Spacial Attack & Defense
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