using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dusclops Species to store common natural stats of all Dusclopss
	#region DusclopsSpecies
	public class DusclopsSpecies : PokemonSpecies
	{
#nullable enable
		private static DusclopsSpecies? _instance = null;
#nullable restore
        public static DusclopsSpecies Instance => _instance ?? (_instance = new DusclopsSpecies());

		#region DusclopsSpecies Constructor
		public DusclopsSpecies() : base(
			356,
			"Dusclops",
			Ghost.Instance,
			1.6,
			30.6,
			new PokemonStats(
				40, // HPs
				70, 130, // Attack & Defense
				60, 130, // Spacial Attack & Defense
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Bind",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Metronome",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Nightmare",
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
				"Dynamic-Punch",
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