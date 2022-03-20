using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gastrodon Species to store common natural stats of all Gastrodons
	#region GastrodonSpecies
	public class GastrodonSpecies : PokemonSpecies
	{
#nullable enable
		private static GastrodonSpecies? _instance = null;
#nullable restore
        public static GastrodonSpecies Instance => _instance ?? (_instance = new GastrodonSpecies());

		#region GastrodonSpecies Constructor
		public GastrodonSpecies() : base(
			423,
			"Gastrodon",
			Water.Instance, Ground.Instance,
			0.9,
			29.9,
			new PokemonStats(
				111, // HPs
				83, 68, // Attack & Defense
				92, 82, // Spacial Attack & Defense
				39 // Speed
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
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"String-Shot",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Recover",
				"Harden",
				"Waterfall",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Muddy-Water",
				"Block",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Earth-Power",
				"Giga-Impact",
				"Mud-Bomb",
				"Stone-Edge",
				"Captivate",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}