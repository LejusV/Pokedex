using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kakuna Species to store common natural stats of all Kakunas
	#region KakunaSpecies
	public class KakunaSpecies : PokemonSpecies
	{
#nullable enable
		private static KakunaSpecies? _instance = null;
#nullable restore
        public static KakunaSpecies Instance => _instance ?? (_instance = new KakunaSpecies());

		#region KakunaSpecies Constructor
		public KakunaSpecies() : base(
			14,
			"Kakuna",
			Bug.Instance, Poison.Instance,
			0.6,
			10.0,
			new PokemonStats(
				45, // HPs
				25, 50, // Attack & Defense
				25, 25, // Spacial Attack & Defense
				35 // Speed
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