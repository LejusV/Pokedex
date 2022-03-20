using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Butterfree Species to store common natural stats of all Butterfrees
	#region ButterfreeSpecies
	public class ButterfreeSpecies : PokemonSpecies
	{
#nullable enable
		private static ButterfreeSpecies? _instance = null;
#nullable restore
        public static ButterfreeSpecies Instance => _instance ?? (_instance = new ButterfreeSpecies());

		#region ButterfreeSpecies Constructor
		public ButterfreeSpecies() : base(
			12,
			"Butterfree",
			Bug.Instance, Flying.Instance,
			1.1,
			32.0,
			new PokemonStats(
				60, // HPs
				45, 50, // Attack & Defense
				90, 80, // Spacial Attack & Defense
				70 // Speed
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
				"Razor-Wind",
				"Gust",
				"Whirlwind",
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Psybeam",
				"Hyper-Beam",
				"Mega-Drain",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Skill-Swap",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
				"Rage-Powder",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Electroweb",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}