using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Espeon Species to store common natural stats of all Espeons
	#region EspeonSpecies
	public class EspeonSpecies : PokemonSpecies
	{
#nullable enable
		private static EspeonSpecies? _instance = null;
#nullable restore
        public static EspeonSpecies Instance => _instance ?? (_instance = new EspeonSpecies());

		#region EspeonSpecies Constructor
		public EspeonSpecies() : base(
			196,
			"Espeon",
			Psychic.Instance,
			0.9,
			26.5,
			new PokemonStats(
				65, // HPs
				65, 60, // Attack & Defense
				130, 95, // Spacial Attack & Defense
				110 // Speed
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Psybeam",
				"Hyper-Beam",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Morning-Sun",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Natural-Gift",
				"Power-Swap",
				"Last-Resort",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}