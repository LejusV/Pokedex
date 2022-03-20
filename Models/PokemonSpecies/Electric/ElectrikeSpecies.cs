using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Electrike Species to store common natural stats of all Electrikes
	#region ElectrikeSpecies
	public class ElectrikeSpecies : PokemonSpecies
	{
#nullable enable
		private static ElectrikeSpecies? _instance = null;
#nullable restore
        public static ElectrikeSpecies Instance => _instance ?? (_instance = new ElectrikeSpecies());

		#region ElectrikeSpecies Constructor
		public ElectrikeSpecies() : base(
			309,
			"Electrike",
			Electric.Instance,
			0.6,
			15.2,
			new PokemonStats(
				40, // HPs
				45, 40, // Attack & Defense
				65, 40, // Spacial Attack & Defense
				65 // Speed
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
				"Curse",
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
				"Crunch",
				"Uproar",
				"Facade",
				"Charge",
				"Secret-Power",
				"Odor-Sleuth",
				"Signal-Beam",
				"Howl",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Switcheroo",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Flame-Burst",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Eerie-Impulse"
			};
		}
		#endregion
	}
	#endregion
}