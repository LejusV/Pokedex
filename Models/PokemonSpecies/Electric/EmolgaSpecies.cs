using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Emolga Species to store common natural stats of all Emolgas
	#region EmolgaSpecies
	public class EmolgaSpecies : PokemonSpecies
	{
#nullable enable
		private static EmolgaSpecies? _instance = null;
#nullable restore
        public static EmolgaSpecies Instance => _instance ?? (_instance = new EmolgaSpecies());

		#region EmolgaSpecies Constructor
		public EmolgaSpecies() : base(
			587,
			"Emolga",
			Electric.Instance, Flying.Instance,
			0.4,
			5.0,
			new PokemonStats(
				55, // HPs
				75, 60, // Attack & Defense
				75, 60, // Spacial Attack & Defense
				103 // Speed
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
				"Cut",
				"Tail-Whip",
				"Thunder-Shock",
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
				"Charm",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Encore",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Charge",
				"Taunt",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Astonish",
				"Tickle",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Air-Slash",
				"Discharge",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Acrobatics",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide",
				"Nuzzle",
				"Speed-Swap"
			};
		}
		#endregion
	}
	#endregion
}