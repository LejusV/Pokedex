using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Grubbin Species to store common natural stats of all Grubbins
	#region GrubbinSpecies
	public class GrubbinSpecies : PokemonSpecies
	{
#nullable enable
		private static GrubbinSpecies? _instance = null;
#nullable restore
        public static GrubbinSpecies Instance => _instance ?? (_instance = new GrubbinSpecies());

		#region GrubbinSpecies Constructor
		public GrubbinSpecies() : base(
			736,
			"Grubbin",
			Bug.Instance,
			0.4,
			4.4,
			new PokemonStats(
				47, // HPs
				62, 45, // Attack & Defense
				55, 45, // Spacial Attack & Defense
				46 // Speed
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
				"Vice-Grip",
				"Bite",
				"String-Shot",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Double-Team",
				"Harden",
				"Light-Screen",
				"Rest",
				"Substitute",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Facade",
				"Mud-Shot",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Bite",
				"Charge-Beam",
				"Round",
				"Acrobatics",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}