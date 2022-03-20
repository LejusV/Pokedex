using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Indeedee-Male Species to store common natural stats of all Indeedee-Males
	#region Indeedee-MaleSpecies
	public class IndeedeeMaleSpecies : PokemonSpecies
	{
#nullable enable
		private static IndeedeeMaleSpecies? _instance = null;
#nullable restore
        public static IndeedeeMaleSpecies Instance => _instance ?? (_instance = new IndeedeeMaleSpecies());

		#region Indeedee-MaleSpecies Constructor
		public IndeedeeMaleSpecies() : base(
			876,
			"Indeedee-Male",
			Psychic.Instance, Normal.Instance,
			0.9,
			28.0,
			new PokemonStats(
				60, // HPs
				65, 55, // Attack & Defense
				105, 95, // Spacial Attack & Defense
				95 // Speed
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