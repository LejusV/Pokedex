using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Slugma Species to store common natural stats of all Slugmas
	#region SlugmaSpecies
	public class SlugmaSpecies : PokemonSpecies
	{
#nullable enable
		private static SlugmaSpecies? _instance = null;
#nullable restore
        public static SlugmaSpecies Instance => _instance ?? (_instance = new SlugmaSpecies());

		#region SlugmaSpecies Constructor
		public SlugmaSpecies() : base(
			218,
			"Slugma",
			Fire.Instance,
			0.7,
			35.0,
			new PokemonStats(
				40, // HPs
				40, 40, // Attack & Defense
				70, 40, // Spacial Attack & Defense
				20 // Speed
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
				"Ember",
				"Flamethrower",
				"Rock-Throw",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Harden",
				"Smokescreen",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Smog",
				"Fire-Blast",
				"Amnesia",
				"Acid-Armor",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Heat-Wave",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Nature-Power",
				"Yawn",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Iron-Defense",
				"Natural-Gift",
				"Guard-Swap",
				"Earth-Power",
				"Lava-Plume",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"After-You",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Inferno",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}