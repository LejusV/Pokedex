using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hippopotas Species to store common natural stats of all Hippopotass
	#region HippopotasSpecies
	public class HippopotasSpecies : PokemonSpecies
	{
#nullable enable
		private static HippopotasSpecies? _instance = null;
#nullable restore
        public static HippopotasSpecies Instance => _instance ?? (_instance = new HippopotasSpecies());

		#region HippopotasSpecies Constructor
		public HippopotasSpecies() : base(
			449,
			"Hippopotas",
			Ground.Instance,
			0.8,
			49.5,
			new PokemonStats(
				68, // HPs
				72, 78, // Attack & Defense
				38, 42, // Spacial Attack & Defense
				32 // Speed
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
				"Whirlwind",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Superpower",
				"Revenge",
				"Yawn",
				"Secret-Power",
				"Slack-Off",
				"Rock-Tomb",
				"Sand-Tomb",
				"Water-Pulse",
				"Natural-Gift",
				"Earth-Power",
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