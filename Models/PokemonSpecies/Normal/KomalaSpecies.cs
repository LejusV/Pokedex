using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Komala Species to store common natural stats of all Komalas
	#region KomalaSpecies
	public class KomalaSpecies : PokemonSpecies
	{
#nullable enable
		private static KomalaSpecies? _instance = null;
#nullable restore
        public static KomalaSpecies Instance => _instance ?? (_instance = new KomalaSpecies());

		#region KomalaSpecies Constructor
		public KomalaSpecies() : base(
			775,
			"Komala",
			Normal.Instance,
			0.4,
			19.9,
			new PokemonStats(
				65, // HPs
				115, 65, // Attack & Defense
				75, 95, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Slam",
				"Thrash",
				"Sing",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Rock-Slide",
				"Substitute",
				"Flail",
				"Protect",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Wish",
				"Brick-Break",
				"Yawn",
				"Bulk-Up",
				"Calm-Mind",
				"U-Turn",
				"Payback",
				"Sucker-Punch",
				"Shadow-Claw",
				"Wood-Hammer",
				"Low-Sweep",
				"Round",
				"Quash",
				"Acrobatics",
				"Bulldoze",
				"Work-Up",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}