using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Torkoal Species to store common natural stats of all Torkoals
	#region TorkoalSpecies
	public class TorkoalSpecies : PokemonSpecies
	{
#nullable enable
		private static TorkoalSpecies? _instance = null;
#nullable restore
        public static TorkoalSpecies Instance => _instance ?? (_instance = new TorkoalSpecies());

		#region TorkoalSpecies Constructor
		public TorkoalSpecies() : base(
			324,
			"Torkoal",
			Fire.Instance,
			0.5,
			80.4,
			new PokemonStats(
				70, // HPs
				85, 140, // Attack & Defense
				85, 70, // Spacial Attack & Defense
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Withdraw",
				"Self-Destruct",
				"Smog",
				"Fire-Blast",
				"Skull-Bash",
				"Amnesia",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Superpower",
				"Yawn",
				"Eruption",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Iron-Defense",
				"Gyro-Ball",
				"Natural-Gift",
				"Earth-Power",
				"Giga-Impact",
				"Lava-Plume",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Flame-Burst",
				"Flame-Charge",
				"After-You",
				"Round",
				"Clear-Smog",
				"Shell-Smash",
				"Incinerate",
				"Inferno",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}