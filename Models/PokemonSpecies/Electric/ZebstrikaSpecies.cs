using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zebstrika Species to store common natural stats of all Zebstrikas
	#region ZebstrikaSpecies
	public class ZebstrikaSpecies : PokemonSpecies
	{
#nullable enable
		private static ZebstrikaSpecies? _instance = null;
#nullable restore
        public static ZebstrikaSpecies Instance => _instance ?? (_instance = new ZebstrikaSpecies());

		#region ZebstrikaSpecies Constructor
		public ZebstrikaSpecies() : base(
			523,
			"Zebstrika",
			Electric.Instance,
			1.6,
			79.5,
			new PokemonStats(
				75, // HPs
				100, 63, // Attack & Defense
				80, 63, // Spacial Attack & Defense
				116 // Speed
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
				"Stomp",
				"Thrash",
				"Tail-Whip",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Charge",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"Magnet-Rise",
				"Giga-Impact",
				"Discharge",
				"Charge-Beam",
				"Flame-Charge",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}