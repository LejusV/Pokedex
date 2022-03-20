using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zacian-Hero Species to store common natural stats of all Zacian-Heros
	#region Zacian-HeroSpecies
	public class ZacianHeroSpecies : PokemonSpecies
	{
#nullable enable
		private static ZacianHeroSpecies? _instance = null;
#nullable restore
        public static ZacianHeroSpecies Instance => _instance ?? (_instance = new ZacianHeroSpecies());

		#region Zacian-HeroSpecies Constructor
		public ZacianHeroSpecies() : base(
			888,
			"Zacian-Hero",
			Fairy.Instance,
			2.8,
			110.0,
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