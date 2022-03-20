using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dustox Species to store common natural stats of all Dustoxs
	#region DustoxSpecies
	public class DustoxSpecies : PokemonSpecies
	{
#nullable enable
		private static DustoxSpecies? _instance = null;
#nullable restore
        public static DustoxSpecies Instance => _instance ?? (_instance = new DustoxSpecies());

		#region DustoxSpecies Constructor
		public DustoxSpecies() : base(
			269,
			"Dustox",
			Bug.Instance, Poison.Instance,
			1.2,
			31.6,
			new PokemonStats(
				60, // HPs
				50, 70, // Attack & Defense
				50, 90, // Spacial Attack & Defense
				65 // Speed
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
				"Gust",
				"Whirlwind",
				"Double-Edge",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Poison-Powder",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Moonlight",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
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