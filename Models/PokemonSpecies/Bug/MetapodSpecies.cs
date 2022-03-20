using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Metapod Species to store common natural stats of all Metapods
	#region MetapodSpecies
	public class MetapodSpecies : PokemonSpecies
	{
#nullable enable
		private static MetapodSpecies? _instance = null;
#nullable restore
        public static MetapodSpecies Instance => _instance ?? (_instance = new MetapodSpecies());

		#region MetapodSpecies Constructor
		public MetapodSpecies() : base(
			11,
			"Metapod",
			Bug.Instance,
			0.7,
			9.9,
			new PokemonStats(
				50, // HPs
				20, 55, // Attack & Defense
				25, 25, // Spacial Attack & Defense
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
				"String-Shot",
				"Harden",
				"Iron-Defense",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion
}