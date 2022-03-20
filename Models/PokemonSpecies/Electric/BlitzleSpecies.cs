using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Blitzle Species to store common natural stats of all Blitzles
	#region BlitzleSpecies
	public class BlitzleSpecies : PokemonSpecies
	{
#nullable enable
		private static BlitzleSpecies? _instance = null;
#nullable restore
        public static BlitzleSpecies Instance => _instance ?? (_instance = new BlitzleSpecies());

		#region BlitzleSpecies Constructor
		public BlitzleSpecies() : base(
			522,
			"Blitzle",
			Electric.Instance,
			0.8,
			29.8,
			new PokemonStats(
				45, // HPs
				60, 32, // Attack & Defense
				50, 32, // Spacial Attack & Defense
				76 // Speed
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
				"Double-Kick",
				"Sand-Attack",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Charge",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"Feint",
				"Me-First",
				"Magnet-Rise",
				"Discharge",
				"Charge-Beam",
				"Flame-Charge",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}