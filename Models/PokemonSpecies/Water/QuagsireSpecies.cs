using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Quagsire Species to store common natural stats of all Quagsires
	#region QuagsireSpecies
	public class QuagsireSpecies : PokemonSpecies
	{
#nullable enable
		private static QuagsireSpecies? _instance = null;
#nullable restore
        public static QuagsireSpecies Instance => _instance ?? (_instance = new QuagsireSpecies());

		#region QuagsireSpecies Constructor
		public QuagsireSpecies() : base(
			195,
			"Quagsire",
			Water.Instance, Ground.Instance,
			1.4,
			75.0,
			new PokemonStats(
				95, // HPs
				85, 85, // Attack & Defense
				65, 65, // Spacial Attack & Defense
				35 // Speed
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
				"Ice-Punch",
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Mist",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Haze",
				"Waterfall",
				"Amnesia",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
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
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Muddy-Water",
				"Mud-Shot",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Mud-Bomb",
				"Stone-Edge",
				"Captivate",
				"Sludge-Wave",
				"After-You",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}