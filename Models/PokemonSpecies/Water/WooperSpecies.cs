using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wooper Species to store common natural stats of all Woopers
	#region WooperSpecies
	public class WooperSpecies : PokemonSpecies
	{
#nullable enable
		private static WooperSpecies? _instance = null;
#nullable restore
        public static WooperSpecies Instance => _instance ?? (_instance = new WooperSpecies());

		#region WooperSpecies Constructor
		public WooperSpecies() : base(
			194,
			"Wooper",
			Water.Instance, Ground.Instance,
			0.4,
			8.5,
			new PokemonStats(
				55, // HPs
				45, 45, // Attack & Defense
				25, 25, // Spacial Attack & Defense
				15 // Speed
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
				"Ice-Punch",
				"Slam",
				"Double-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Mist",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Defense-Curl",
				"Haze",
				"Waterfall",
				"Amnesia",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Muddy-Water",
				"Mud-Shot",
				"Water-Pulse",
				"Natural-Gift",
				"Guard-Swap",
				"Aqua-Tail",
				"Earth-Power",
				"Mud-Bomb",
				"Captivate",
				"Sludge-Wave",
				"Acid-Spray",
				"After-You",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Eerie-Impulse",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}