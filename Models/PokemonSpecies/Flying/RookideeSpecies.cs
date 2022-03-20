using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rookidee Species to store common natural stats of all Rookidees
	#region RookideeSpecies
	public class RookideeSpecies : PokemonSpecies
	{
#nullable enable
		private static RookideeSpecies? _instance = null;
#nullable restore
        public static RookideeSpecies Instance => _instance ?? (_instance = new RookideeSpecies());

		#region RookideeSpecies Constructor
		public RookideeSpecies() : base(
			821,
			"Rookidee",
			Flying.Instance,
			0.2,
			1.8,
			new PokemonStats(
				38, // HPs
				47, 35, // Attack & Defense
				33, 35, // Spacial Attack & Defense
				57 // Speed
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