using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Magcargo Species to store common natural stats of all Magcargos
	#region MagcargoSpecies
	public class MagcargoSpecies : PokemonSpecies
	{
#nullable enable
		private static MagcargoSpecies? _instance = null;
#nullable restore
        public static MagcargoSpecies Instance => _instance ?? (_instance = new MagcargoSpecies());

		#region MagcargoSpecies Constructor
		public MagcargoSpecies() : base(
			219,
			"Magcargo",
			Fire.Instance, Rock.Instance,
			0.8,
			55.0,
			new PokemonStats(
				60, // HPs
				50, 120, // Attack & Defense
				90, 80, // Spacial Attack & Defense
				30 // Speed
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
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Harden",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Smog",
				"Fire-Blast",
				"Amnesia",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
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
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Yawn",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Iron-Defense",
				"Gyro-Ball",
				"Natural-Gift",
				"Rock-Polish",
				"Earth-Power",
				"Giga-Impact",
				"Lava-Plume",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Flame-Burst",
				"Flame-Charge",
				"After-You",
				"Round",
				"Clear-Smog",
				"Shell-Smash",
				"Incinerate",
				"Bulldoze",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}