using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gastly Species to store common natural stats of all Gastlys
	#region GastlySpecies
	public class GastlySpecies : PokemonSpecies
	{
#nullable enable
		private static GastlySpecies? _instance = null;
#nullable restore
        public static GastlySpecies Instance => _instance ?? (_instance = new GastlySpecies());

		#region GastlySpecies Constructor
		public GastlySpecies() : base(
			92,
			"Gastly",
			Ghost.Instance, Poison.Instance,
			1.3,
			0.1,
			new PokemonStats(
				30, // HPs
				35, 30, // Attack & Defense
				100, 35, // Spacial Attack & Defense
				80 // Speed
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
				"Disable",
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
				"Haze",
				"Bide",
				"Self-Destruct",
				"Lick",
				"Smog",
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
				"Scary-Face",
				"Sludge-Bomb",
				"Zap-Cannon",
				"Destiny-Bond",
				"Perish-Song",
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
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Knock-Off",
				"Skill-Swap",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Energy-Ball",
				"Trick-Room",
				"Captivate",
				"Ominous-Wind",
				"Wonder-Room",
				"Venoshock",
				"Telekinesis",
				"Foul-Play",
				"Round",
				"Clear-Smog",
				"Hex",
				"Reflect-Type",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}