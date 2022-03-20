using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tirtouga Species to store common natural stats of all Tirtougas
	#region TirtougaSpecies
	public class TirtougaSpecies : PokemonSpecies
	{
#nullable enable
		private static TirtougaSpecies? _instance = null;
#nullable restore
        public static TirtougaSpecies Instance => _instance ?? (_instance = new TirtougaSpecies());

		#region TirtougaSpecies Constructor
		public TirtougaSpecies() : base(
			564,
			"Tirtouga",
			Water.Instance, Rock.Instance,
			0.7,
			16.5,
			new PokemonStats(
				54, // HPs
				78, 103, // Attack & Defense
				53, 45, // Spacial Attack & Defense
				22 // Speed
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
				"Slam",
				"Body-Slam",
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Bide",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Icy-Wind",
				"Sandstorm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Water-Pulse",
				"Brine",
				"Guard-Swap",
				"Rock-Polish",
				"Aqua-Tail",
				"Earth-Power",
				"Zen-Headbutt",
				"Stone-Edge",
				"Stealth-Rock",
				"Aqua-Jet",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Scald",
				"Shell-Smash",
				"Bulldoze",
				"Confide",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion
}