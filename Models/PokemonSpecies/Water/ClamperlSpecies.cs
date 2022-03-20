using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Clamperl Species to store common natural stats of all Clamperls
	#region ClamperlSpecies
	public class ClamperlSpecies : PokemonSpecies
	{
#nullable enable
		private static ClamperlSpecies? _instance = null;
#nullable restore
        public static ClamperlSpecies Instance => _instance ?? (_instance = new ClamperlSpecies());

		#region ClamperlSpecies Constructor
		public ClamperlSpecies() : base(
			366,
			"Clamperl",
			Water.Instance,
			0.4,
			52.5,
			new PokemonStats(
				35, // HPs
				64, 85, // Attack & Defense
				74, 55, // Spacial Attack & Defense
				32 // Speed
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
				"Body-Slam",
				"Double-Edge",
				"Supersonic",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Barrier",
				"Waterfall",
				"Clamp",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Muddy-Water",
				"Iron-Defense",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Ring",
				"Captivate",
				"Round",
				"Scald",
				"Shell-Smash",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}