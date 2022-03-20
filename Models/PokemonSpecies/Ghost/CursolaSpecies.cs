using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cursola Species to store common natural stats of all Cursolas
	#region CursolaSpecies
	public class CursolaSpecies : PokemonSpecies
	{
#nullable enable
		private static CursolaSpecies? _instance = null;
#nullable restore
        public static CursolaSpecies Instance => _instance ?? (_instance = new CursolaSpecies());

		#region CursolaSpecies Constructor
		public CursolaSpecies() : base(
			864,
			"Cursola",
			Ghost.Instance,
			1.0,
			0.4,
			new PokemonStats(
				60, // HPs
				95, 50, // Attack & Defense
				145, 130, // Spacial Attack & Defense
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