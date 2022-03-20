using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zamazenta-Hero Species to store common natural stats of all Zamazenta-Heros
	#region Zamazenta-HeroSpecies
	public class ZamazentaHeroSpecies : PokemonSpecies
	{
#nullable enable
		private static ZamazentaHeroSpecies? _instance = null;
#nullable restore
        public static ZamazentaHeroSpecies Instance => _instance ?? (_instance = new ZamazentaHeroSpecies());

		#region Zamazenta-HeroSpecies Constructor
		public ZamazentaHeroSpecies() : base(
			889,
			"Zamazenta-Hero",
			Fighting.Instance,
			2.9,
			210.0,
			new PokemonStats(
				92, // HPs
				130, 115, // Attack & Defense
				80, 115, // Spacial Attack & Defense
				138 // Speed
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