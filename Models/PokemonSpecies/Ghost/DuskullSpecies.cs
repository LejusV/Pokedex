using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Duskull Species to store common natural stats of all Duskulls
	#region DuskullSpecies
	public class DuskullSpecies : PokemonSpecies
	{
#nullable enable
		private static DuskullSpecies? _instance = null;
#nullable restore
        public static DuskullSpecies Instance => _instance ?? (_instance = new DuskullSpecies());

		#region DuskullSpecies Constructor
		public DuskullSpecies() : base(
			355,
			"Duskull",
			Ghost.Instance,
			0.8,
			15.0,
			new PokemonStats(
				20, // HPs
				40, 90, // Attack & Defense
				30, 90, // Spacial Attack & Defense
				25 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Foresight",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Skill-Swap",
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Calm-Mind",
				"Gravity",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Dark-Pulse",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Wonder-Room",
				"Telekinesis",
				"Round",
				"Hex",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}