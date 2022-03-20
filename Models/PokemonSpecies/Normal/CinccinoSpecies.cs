using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cinccino Species to store common natural stats of all Cinccinos
	#region CinccinoSpecies
	public class CinccinoSpecies : PokemonSpecies
	{
#nullable enable
		private static CinccinoSpecies? _instance = null;
#nullable restore
        public static CinccinoSpecies Instance => _instance ?? (_instance = new CinccinoSpecies());

		#region CinccinoSpecies Constructor
		public CinccinoSpecies() : base(
			573,
			"Cinccino",
			Normal.Instance,
			0.5,
			7.5,
			new PokemonStats(
				75, // HPs
				95, 60, // Attack & Defense
				65, 60, // Spacial Attack & Defense
				115 // Speed
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
				"Sing",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
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
				"Tickle",
				"Bullet-Seed",
				"Covet",
				"Calm-Mind",
				"Rock-Blast",
				"Shock-Wave",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Aqua-Tail",
				"Seed-Bomb",
				"Focus-Blast",
				"Giga-Impact",
				"Gunk-Shot",
				"Grass-Knot",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Tail-Slap",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}