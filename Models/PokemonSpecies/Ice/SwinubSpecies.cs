using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Swinub Species to store common natural stats of all Swinubs
	#region SwinubSpecies
	public class SwinubSpecies : PokemonSpecies
	{
#nullable enable
		private static SwinubSpecies? _instance = null;
#nullable restore
        public static SwinubSpecies Instance => _instance ?? (_instance = new SwinubSpecies());

		#region SwinubSpecies Constructor
		public SwinubSpecies() : base(
			220,
			"Swinub",
			Ice.Instance, Ground.Instance,
			0.4,
			6.5,
			new PokemonStats(
				50, // HPs
				50, 40, // Attack & Defense
				30, 30, // Spacial Attack & Defense
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Earthquake",
				"Fissure",
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
				"Flail",
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
				"Icicle-Spear",
				"Mud-Shot",
				"Natural-Gift",
				"Earth-Power",
				"Avalanche",
				"Ice-Shard",
				"Mud-Bomb",
				"Captivate",
				"Stealth-Rock",
				"Round",
				"Bulldoze",
				"Icicle-Crash",
				"Freeze-Dry",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}