using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rotom Species to store common natural stats of all Rotoms
	#region RotomSpecies
	public class RotomSpecies : PokemonSpecies
	{
#nullable enable
		private static RotomSpecies? _instance = null;
#nullable restore
        public static RotomSpecies Instance => _instance ?? (_instance = new RotomSpecies());

		#region RotomSpecies Constructor
		public RotomSpecies() : base(
			479,
			"Rotom",
			Electric.Instance, Ghost.Instance,
			0.3,
			0.3,
			new PokemonStats(
				50, // HPs
				50, 77, // Attack & Defense
				95, 77, // Spacial Attack & Defense
				91 // Speed
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
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Will-O-Wisp",
				"Facade",
				"Charge",
				"Trick",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Sucker-Punch",
				"Dark-Pulse",
				"Discharge",
				"Charge-Beam",
				"Ominous-Wind",
				"Telekinesis",
				"Electro-Ball",
				"Foul-Play",
				"Round",
				"Hex",
				"Volt-Switch",
				"Electroweb",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}