using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Heliolisk Species to store common natural stats of all Heliolisks
	#region HelioliskSpecies
	public class HelioliskSpecies : PokemonSpecies
	{
#nullable enable
		private static HelioliskSpecies? _instance = null;
#nullable restore
        public static HelioliskSpecies Instance => _instance ?? (_instance = new HelioliskSpecies());

		#region HelioliskSpecies Constructor
		public HelioliskSpecies() : base(
			695,
			"Heliolisk",
			Electric.Instance, Normal.Instance,
			1.0,
			21.0,
			new PokemonStats(
				62, // HPs
				55, 52, // Attack & Defense
				109, 94, // Spacial Attack & Defense
				109 // Speed
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
				"Fire-Punch",
				"Thunder-Punch",
				"Razor-Wind",
				"Cut",
				"Surf",
				"Hyper-Beam",
				"Low-Kick",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Facade",
				"Charge",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Signal-Beam",
				"Shock-Wave",
				"U-Turn",
				"Magnet-Rise",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Grass-Knot",
				"Charge-Beam",
				"Low-Sweep",
				"Round",
				"Volt-Switch",
				"Bulldoze",
				"Dragon-Tail",
				"Electroweb",
				"Wild-Charge",
				"Parabolic-Charge",
				"Electrify",
				"Confide",
				"Eerie-Impulse",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}