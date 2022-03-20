using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Milotic Species to store common natural stats of all Milotics
	#region MiloticSpecies
	public class MiloticSpecies : PokemonSpecies
	{
#nullable enable
		private static MiloticSpecies? _instance = null;
#nullable restore
        public static MiloticSpecies Instance => _instance ?? (_instance = new MiloticSpecies());

		#region MiloticSpecies Constructor
		public MiloticSpecies() : base(
			350,
			"Milotic",
			Water.Instance,
			6.2,
			162.0,
			new PokemonStats(
				95, // HPs
				60, 79, // Attack & Defense
				100, 125, // Spacial Attack & Defense
				81 // Speed
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
				"Bind",
				"Body-Slam",
				"Wrap",
				"Double-Edge",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Waterfall",
				"Swift",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Psych-Up",
				"Whirlpool",
				"Hail",
				"Facade",
				"Magic-Coat",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Ring",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Giga-Impact",
				"Avalanche",
				"Iron-Head",
				"Captivate",
				"Coil",
				"Round",
				"Scald",
				"Bulldoze",
				"Dragon-Tail",
				"Disarming-Voice",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}