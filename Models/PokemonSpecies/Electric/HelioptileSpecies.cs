using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Helioptile Species to store common natural stats of all Helioptiles
	#region HelioptileSpecies
	public class HelioptileSpecies : PokemonSpecies
	{
#nullable enable
		private static HelioptileSpecies? _instance = null;
#nullable restore
        public static HelioptileSpecies Instance => _instance ?? (_instance = new HelioptileSpecies());

		#region HelioptileSpecies Constructor
		public HelioptileSpecies() : base(
			694,
			"Helioptile",
			Electric.Instance, Normal.Instance,
			0.5,
			6.0,
			new PokemonStats(
				44, // HPs
				38, 33, // Attack & Defense
				61, 43, // Spacial Attack & Defense
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
				"Pound",
				"Razor-Wind",
				"Cut",
				"Tail-Whip",
				"Surf",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Glare",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
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
				"Camouflage",
				"Rock-Tomb",
				"Signal-Beam",
				"Shock-Wave",
				"U-Turn",
				"Magnet-Rise",
				"Dark-Pulse",
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
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion
}