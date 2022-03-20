using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mudkip Species to store common natural stats of all Mudkips
	#region MudkipSpecies
	public class MudkipSpecies : PokemonSpecies
	{
#nullable enable
		private static MudkipSpecies? _instance = null;
#nullable restore
        public static MudkipSpecies Instance => _instance ?? (_instance = new MudkipSpecies());

		#region MudkipSpecies Constructor
		public MudkipSpecies() : base(
			258,
			"Mudkip",
			Water.Instance,
			0.4,
			7.6,
			new PokemonStats(
				50, // HPs
				70, 50, // Attack & Defense
				50, 50, // Spacial Attack & Defense
				40 // Speed
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
				"Stomp",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Growl",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Strength",
				"Rock-Throw",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Barrier",
				"Bide",
				"Sludge",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Superpower",
				"Yawn",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Ice-Ball",
				"Rock-Tomb",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Tail",
				"Earth-Power",
				"Avalanche",
				"Mud-Bomb",
				"Captivate",
				"Wide-Guard",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Water-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}