using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Melmetal Species to store common natural stats of all Melmetals
	#region MelmetalSpecies
	public class MelmetalSpecies : PokemonSpecies
	{
#nullable enable
		private static MelmetalSpecies? _instance = null;
#nullable restore
        public static MelmetalSpecies Instance => _instance ?? (_instance = new MelmetalSpecies());

		#region MelmetalSpecies Constructor
		public MelmetalSpecies() : base(
			809,
			"Melmetal",
			Steel.Instance,
			2.5,
			800.0,
			new PokemonStats(
				135, // HPs
				143, 143, // Attack & Defense
				80, 65, // Spacial Attack & Defense
				34 // Speed
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