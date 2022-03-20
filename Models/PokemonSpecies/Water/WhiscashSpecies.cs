using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Whiscash Species to store common natural stats of all Whiscashs
	#region WhiscashSpecies
	public class WhiscashSpecies : PokemonSpecies
	{
#nullable enable
		private static WhiscashSpecies? _instance = null;
#nullable restore
        public static WhiscashSpecies Instance => _instance ?? (_instance = new WhiscashSpecies());

		#region WhiscashSpecies Constructor
		public WhiscashSpecies() : base(
			340,
			"Whiscash",
			Water.Instance, Ground.Instance,
			0.9,
			23.6,
			new PokemonStats(
				110, // HPs
				78, 73, // Attack & Defense
				76, 71, // Spacial Attack & Defense
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
				"Thrash",
				"Double-Edge",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Waterfall",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Rain-Dance",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Tickle",
				"Muddy-Water",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Tail",
				"Earth-Power",
				"Giga-Impact",
				"Mud-Bomb",
				"Zen-Headbutt",
				"Stone-Edge",
				"Captivate",
				"Round",
				"Scald",
				"Bulldoze",
				"Belch",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}