using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Luxio Species to store common natural stats of all Luxios
	#region LuxioSpecies
	public class LuxioSpecies : PokemonSpecies
	{
#nullable enable
		private static LuxioSpecies? _instance = null;
#nullable restore
        public static LuxioSpecies Instance => _instance ?? (_instance = new LuxioSpecies());

		#region LuxioSpecies Constructor
		public LuxioSpecies() : base(
			404,
			"Luxio",
			Electric.Instance,
			0.9,
			30.5,
			new PokemonStats(
				60, // HPs
				85, 49, // Attack & Defense
				60, 49, // Spacial Attack & Defense
				60 // Speed
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
				"Headbutt",
				"Tackle",
				"Leer",
				"Bite",
				"Roar",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Spark",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Secret-Power",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Thunder-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}