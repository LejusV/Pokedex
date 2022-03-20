using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gengar Species to store common natural stats of all Gengars
	#region GengarSpecies
	public class GengarSpecies : PokemonSpecies
	{
#nullable enable
		private static GengarSpecies? _instance = null;
#nullable restore
        public static GengarSpecies Instance => _instance ?? (_instance = new GengarSpecies());

		#region GengarSpecies Constructor
		public GengarSpecies() : base(
			94,
			"Gengar",
			Ghost.Instance, Poison.Instance,
			1.5,
			40.5,
			new PokemonStats(
				60, // HPs
				65, 60, // Attack & Defense
				130, 75, // Spacial Attack & Defense
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Mega-Drain",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Bide",
				"Metronome",
				"Self-Destruct",
				"Lick",
				"Skull-Bash",
				"Dream-Eater",
				"Psywave",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Zap-Cannon",
				"Destiny-Bond",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Shadow-Punch",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Trick-Room",
				"Captivate",
				"Ominous-Wind",
				"Wonder-Room",
				"Venoshock",
				"Telekinesis",
				"Foul-Play",
				"Round",
				"Hex",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}