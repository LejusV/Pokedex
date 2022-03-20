using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Luxray Species to store common natural stats of all Luxrays
	#region LuxraySpecies
	public class LuxraySpecies : PokemonSpecies
	{
#nullable enable
		private static LuxraySpecies? _instance = null;
#nullable restore
        public static LuxraySpecies Instance => _instance ?? (_instance = new LuxraySpecies());

		#region LuxraySpecies Constructor
		public LuxraySpecies() : base(
			405,
			"Luxray",
			Electric.Instance,
			1.4,
			42.0,
			new PokemonStats(
				80, // HPs
				120, 79, // Attack & Defense
				95, 79, // Spacial Attack & Defense
				70 // Speed
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
				"Hyper-Beam",
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
				"Superpower",
				"Secret-Power",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Giga-Impact",
				"Thunder-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion
}