using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pachirisu Species to store common natural stats of all Pachirisus
	#region PachirisuSpecies
	public class PachirisuSpecies : PokemonSpecies
	{
#nullable enable
		private static PachirisuSpecies? _instance = null;
#nullable restore
        public static PachirisuSpecies Instance => _instance ?? (_instance = new PachirisuSpecies());

		#region PachirisuSpecies Constructor
		public PachirisuSpecies() : base(
			417,
			"Pachirisu",
			Electric.Instance,
			0.4,
			3.9,
			new PokemonStats(
				60, // HPs
				45, 70, // Attack & Defense
				45, 90, // Spacial Attack & Defense
				95 // Speed
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
				"Thunder-Punch",
				"Cut",
				"Headbutt",
				"Tail-Whip",
				"Bite",
				"Growl",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Bide",
				"Swift",
				"Flash",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Flatter",
				"Facade",
				"Follow-Me",
				"Charge",
				"Helping-Hand",
				"Secret-Power",
				"Fake-Tears",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Magnet-Rise",
				"Seed-Bomb",
				"Discharge",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Echoed-Voice",
				"Bestow",
				"Volt-Switch",
				"Electroweb",
				"Ion-Deluge",
				"Confide",
				"Baby-Doll-Eyes",
				"Nuzzle"
			};
		}
		#endregion
	}
	#endregion
}