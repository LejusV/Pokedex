using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Grapploct Species to store common natural stats of all Grapplocts
	#region GrapploctSpecies
	public class GrapploctSpecies : PokemonSpecies
	{
#nullable enable
		private static GrapploctSpecies? _instance = null;
#nullable restore
        public static GrapploctSpecies Instance => _instance ?? (_instance = new GrapploctSpecies());

		#region GrapploctSpecies Constructor
		public GrapploctSpecies() : base(
			853,
			"Grapploct",
			Fighting.Instance,
			1.6,
			39.0,
			new PokemonStats(
				80, // HPs
				118, 90, // Attack & Defense
				70, 80, // Spacial Attack & Defense
				42 // Speed
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