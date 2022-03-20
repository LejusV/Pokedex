using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Manectric Species to store common natural stats of all Manectrics
	#region ManectricSpecies
	public class ManectricSpecies : PokemonSpecies
	{
#nullable enable
		private static ManectricSpecies? _instance = null;
#nullable restore
        public static ManectricSpecies Instance => _instance ?? (_instance = new ManectricSpecies());

		#region ManectricSpecies Constructor
		public ManectricSpecies() : base(
			310,
			"Manectric",
			Electric.Instance,
			1.5,
			40.2,
			new PokemonStats(
				70, // HPs
				75, 60, // Attack & Defense
				105, 60, // Spacial Attack & Defense
				105 // Speed
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
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Facade",
				"Charge",
				"Secret-Power",
				"Overheat",
				"Odor-Sleuth",
				"Signal-Beam",
				"Howl",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Giga-Impact",
				"Thunder-Fang",
				"Fire-Fang",
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