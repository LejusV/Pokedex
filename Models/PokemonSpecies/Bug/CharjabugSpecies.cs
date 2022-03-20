using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Charjabug Species to store common natural stats of all Charjabugs
	#region CharjabugSpecies
	public class CharjabugSpecies : PokemonSpecies
	{
#nullable enable
		private static CharjabugSpecies? _instance = null;
#nullable restore
        public static CharjabugSpecies Instance => _instance ?? (_instance = new CharjabugSpecies());

		#region CharjabugSpecies Constructor
		public CharjabugSpecies() : base(
			737,
			"Charjabug",
			Bug.Instance, Electric.Instance,
			0.5,
			10.5,
			new PokemonStats(
				57, // HPs
				82, 95, // Attack & Defense
				55, 75, // Spacial Attack & Defense
				36 // Speed
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
				"Light-Screen",
				"Rest",
				"Substitute",
				"Protect",
				"Mud-Slap",
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
				"Charge",
				"Iron-Defense",
				"Poison-Jab",
				"X-Scissor",
				"Discharge",
				"Bug-Bite",
				"Charge-Beam",
				"Round",
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