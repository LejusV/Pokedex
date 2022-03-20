using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dusknoir Species to store common natural stats of all Dusknoirs
	#region DusknoirSpecies
	public class DusknoirSpecies : PokemonSpecies
	{
#nullable enable
		private static DusknoirSpecies? _instance = null;
#nullable restore
        public static DusknoirSpecies Instance => _instance ?? (_instance = new DusknoirSpecies());

		#region DusknoirSpecies Constructor
		public DusknoirSpecies() : base(
			477,
			"Dusknoir",
			Ghost.Instance,
			2.2,
			106.6,
			new PokemonStats(
				45, // HPs
				100, 135, // Attack & Defense
				65, 135, // Spacial Attack & Defense
				45 // Speed
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
				"Ice-Punch",
				"Thunder-Punch",
				"Bind",
				"Headbutt",
				"Leer",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Confuse-Ray",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Foresight",
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
				"Rock-Smash",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Shadow-Punch",
				"Calm-Mind",
				"Gravity",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Dark-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Wonder-Room",
				"Telekinesis",
				"Round",
				"Hex",
				"Bulldoze",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}