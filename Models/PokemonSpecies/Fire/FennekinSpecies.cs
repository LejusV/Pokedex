using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Fennekin Species to store common natural stats of all Fennekins
	#region FennekinSpecies
	public class FennekinSpecies : PokemonSpecies
	{
#nullable enable
		private static FennekinSpecies? _instance = null;
#nullable restore
        public static FennekinSpecies Instance => _instance ?? (_instance = new FennekinSpecies());

		#region FennekinSpecies Constructor
		public FennekinSpecies() : base(
			653,
			"Fennekin",
			Fire.Instance,
			0.4,
			9.4,
			new PokemonStats(
				40, // HPs
				45, 40, // Attack & Defense
				62, 60, // Spacial Attack & Defense
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
				"Scratch",
				"Cut",
				"Tail-Whip",
				"Ember",
				"Flamethrower",
				"Psybeam",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Dream-Eater",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Wish",
				"Magic-Coat",
				"Secret-Power",
				"Overheat",
				"Howl",
				"Covet",
				"Embargo",
				"Lucky-Chant",
				"Grass-Knot",
				"Psyshock",
				"Magic-Room",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion
}