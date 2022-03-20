using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Feebas Species to store common natural stats of all Feebass
	#region FeebasSpecies
	public class FeebasSpecies : PokemonSpecies
	{
#nullable enable
		private static FeebasSpecies? _instance = null;
#nullable restore
        public static FeebasSpecies Instance => _instance ?? (_instance = new FeebasSpecies());

		#region FeebasSpecies Constructor
		public FeebasSpecies() : base(
			349,
			"Feebas",
			Water.Instance,
			0.6,
			7.4,
			new PokemonStats(
				20, // HPs
				15, 20, // Attack & Defense
				10, 55, // Spacial Attack & Defense
				80 // Speed
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
				"Tackle",
				"Double-Edge",
				"Mist",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Haze",
				"Waterfall",
				"Swift",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Tickle",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Dragon-Pulse",
				"Captivate",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}