using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wailmer Species to store common natural stats of all Wailmers
	#region WailmerSpecies
	public class WailmerSpecies : PokemonSpecies
	{
#nullable enable
		private static WailmerSpecies? _instance = null;
#nullable restore
        public static WailmerSpecies Instance => _instance ?? (_instance = new WailmerSpecies());

		#region WailmerSpecies Constructor
		public WailmerSpecies() : base(
			320,
			"Wailmer",
			Water.Instance,
			2.0,
			130.0,
			new PokemonStats(
				130, // HPs
				70, 35, // Attack & Defense
				70, 35, // Spacial Attack & Defense
				60 // Speed
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
				"Thrash",
				"Double-Edge",
				"Growl",
				"Roar",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Self-Destruct",
				"Waterfall",
				"Amnesia",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Astonish",
				"Rock-Tomb",
				"Tickle",
				"Water-Spout",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Ring",
				"Avalanche",
				"Zen-Headbutt",
				"Captivate",
				"Heavy-Slam",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Clear-Smog",
				"Scald",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}