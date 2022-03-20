using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Raikou Species to store common natural stats of all Raikous
	#region RaikouSpecies
	public class RaikouSpecies : PokemonSpecies
	{
#nullable enable
		private static RaikouSpecies? _instance = null;
#nullable restore
        public static RaikouSpecies Instance => _instance ?? (_instance = new RaikouSpecies());

		#region RaikouSpecies Constructor
		public RaikouSpecies() : base(
			243,
			"Raikou",
			Electric.Instance,
			1.9,
			178.0,
			new PokemonStats(
				90, // HPs
				85, 75, // Attack & Defense
				115, 100, // Spacial Attack & Defense
				115 // Speed
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
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Spark",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Secret-Power",
				"Signal-Beam",
				"Extrasensory",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Giga-Impact",
				"Thunder-Fang",
				"Rock-Climb",
				"Discharge",
				"Iron-Head",
				"Charge-Beam",
				"Round",
				"Quash",
				"Volt-Switch",
				"Bulldoze",
				"Wild-Charge",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}