using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vikavolt Species to store common natural stats of all Vikavolts
	#region VikavoltSpecies
	public class VikavoltSpecies : PokemonSpecies
	{
#nullable enable
		private static VikavoltSpecies? _instance = null;
#nullable restore
        public static VikavoltSpecies Instance => _instance ?? (_instance = new VikavoltSpecies());

		#region VikavoltSpecies Constructor
		public VikavoltSpecies() : base(
			738,
			"Vikavolt",
			Bug.Instance, Electric.Instance,
			1.5,
			45.0,
			new PokemonStats(
				77, // HPs
				70, 90, // Attack & Defense
				145, 75, // Spacial Attack & Defense
				43 // Speed
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
				"Guillotine",
				"Bite",
				"Hyper-Beam",
				"Solar-Beam",
				"String-Shot",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Double-Team",
				"Light-Screen",
				"Rest",
				"Substitute",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Charge",
				"Roost",
				"Poison-Jab",
				"Air-Slash",
				"X-Scissor",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Flash-Cannon",
				"Bug-Bite",
				"Charge-Beam",
				"Round",
				"Sky-Drop",
				"Acrobatics",
				"Volt-Switch",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}