using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Jellicent Species to store common natural stats of all Jellicents
	#region JellicentSpecies
	public class JellicentSpecies : PokemonSpecies
	{
#nullable enable
		private static JellicentSpecies? _instance = null;
#nullable restore
        public static JellicentSpecies Instance => _instance ?? (_instance = new JellicentSpecies());

		#region JellicentSpecies Constructor
		public JellicentSpecies() : base(
			593,
			"Jellicent",
			Water.Instance, Ghost.Instance,
			2.2,
			135.0,
			new PokemonStats(
				100, // HPs
				60, 70, // Attack & Defense
				85, 105, // Spacial Attack & Defense
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
				"Bind",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Absorb",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Recover",
				"Waterfall",
				"Dream-Eater",
				"Bubble",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Hail",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Magic-Coat",
				"Secret-Power",
				"Dive",
				"Water-Spout",
				"Water-Sport",
				"Shock-Wave",
				"Water-Pulse",
				"Brine",
				"Wring-Out",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Trick-Room",
				"Ominous-Wind",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Hex",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}