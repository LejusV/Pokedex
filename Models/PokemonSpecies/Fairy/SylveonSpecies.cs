using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sylveon Species to store common natural stats of all Sylveons
	#region SylveonSpecies
	public class SylveonSpecies : PokemonSpecies
	{
#nullable enable
		private static SylveonSpecies? _instance = null;
#nullable restore
        public static SylveonSpecies Instance => _instance ?? (_instance = new SylveonSpecies());

		#region SylveonSpecies Constructor
		public SylveonSpecies() : base(
			700,
			"Sylveon",
			Fairy.Instance,
			1.0,
			23.5,
			new PokemonStats(
				95, // HPs
				65, 65, // Attack & Defense
				110, 130, // Spacial Attack & Defense
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
				"Cut",
				"Sand-Attack",
				"Tackle",
				"Tail-Whip",
				"Hyper-Beam",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Helping-Hand",
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Hyper-Voice",
				"Covet",
				"Calm-Mind",
				"Last-Resort",
				"Giga-Impact",
				"Psyshock",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Fairy-Wind",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}