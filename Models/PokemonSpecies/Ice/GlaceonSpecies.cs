using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Glaceon Species to store common natural stats of all Glaceons
	#region GlaceonSpecies
	public class GlaceonSpecies : PokemonSpecies
	{
#nullable enable
		private static GlaceonSpecies? _instance = null;
#nullable restore
        public static GlaceonSpecies Instance => _instance ?? (_instance = new GlaceonSpecies());

		#region GlaceonSpecies Constructor
		public GlaceonSpecies() : base(
			471,
			"Glaceon",
			Ice.Instance,
			0.8,
			25.9,
			new PokemonStats(
				65, // HPs
				60, 110, // Attack & Defense
				130, 95, // Spacial Attack & Defense
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Tail-Whip",
				"Bite",
				"Roar",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Barrier",
				"Swift",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Shadow-Ball",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Covet",
				"Water-Pulse",
				"Natural-Gift",
				"Last-Resort",
				"Aqua-Tail",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Ice-Fang",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Frost-Breath",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion
}