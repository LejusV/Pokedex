using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Minccino Species to store common natural stats of all Minccinos
	#region MinccinoSpecies
	public class MinccinoSpecies : PokemonSpecies
	{
#nullable enable
		private static MinccinoSpecies? _instance = null;
#nullable restore
        public static MinccinoSpecies Instance => _instance ?? (_instance = new MinccinoSpecies());

		#region MinccinoSpecies Constructor
		public MinccinoSpecies() : base(
			572,
			"Minccino",
			Normal.Instance,
			0.4,
			5.8,
			new PokemonStats(
				55, // HPs
				50, 40, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				75 // Speed
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
				"Pound",
				"Double-Slap",
				"Slam",
				"Tail-Whip",
				"Growl",
				"Sing",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Double-Team",
				"Swift",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Tickle",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Wake-Up-Slap",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Aqua-Tail",
				"Seed-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Tail-Slap",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}