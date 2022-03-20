using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wailord Species to store common natural stats of all Wailords
	#region WailordSpecies
	public class WailordSpecies : PokemonSpecies
	{
#nullable enable
		private static WailordSpecies? _instance = null;
#nullable restore
        public static WailordSpecies Instance => _instance ?? (_instance = new WailordSpecies());

		#region WailordSpecies Constructor
		public WailordSpecies() : base(
			321,
			"Wailord",
			Water.Instance,
			14.5,
			398.0,
			new PokemonStats(
				170, // HPs
				90, 45, // Attack & Defense
				90, 45, // Spacial Attack & Defense
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
				"Double-Edge",
				"Growl",
				"Roar",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
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
				"Water-Spout",
				"Block",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Iron-Head",
				"Captivate",
				"Heavy-Slam",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Bulldoze",
				"Noble-Roar",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}