using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Piloswine Species to store common natural stats of all Piloswines
	#region PiloswineSpecies
	public class PiloswineSpecies : PokemonSpecies
	{
#nullable enable
		private static PiloswineSpecies? _instance = null;
#nullable restore
        public static PiloswineSpecies Instance => _instance ?? (_instance = new PiloswineSpecies());

		#region PiloswineSpecies Constructor
		public PiloswineSpecies() : base(
			221,
			"Piloswine",
			Ice.Instance, Ground.Instance,
			1.1,
			55.8,
			new PokemonStats(
				100, // HPs
				100, 80, // Attack & Defense
				60, 60, // Spacial Attack & Defense
				50 // Speed
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
				"Horn-Attack",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Roar",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Peck",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Mud-Sport",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Natural-Gift",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Mud-Bomb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}