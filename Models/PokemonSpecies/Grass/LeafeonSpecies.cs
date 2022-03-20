using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Leafeon Species to store common natural stats of all Leafeons
	#region LeafeonSpecies
	public class LeafeonSpecies : PokemonSpecies
	{
#nullable enable
		private static LeafeonSpecies? _instance = null;
#nullable restore
        public static LeafeonSpecies Instance => _instance ?? (_instance = new LeafeonSpecies());

		#region LeafeonSpecies Constructor
		public LeafeonSpecies() : base(
			470,
			"Leafeon",
			Grass.Instance,
			1.0,
			25.5,
			new PokemonStats(
				65, // HPs
				110, 130, // Attack & Defense
				60, 65, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Tail-Whip",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Razor-Leaf",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Grass-Whistle",
				"Bullet-Seed",
				"Aerial-Ace",
				"Covet",
				"Magical-Leaf",
				"Leaf-Blade",
				"Natural-Gift",
				"Last-Resort",
				"Worry-Seed",
				"Seed-Bomb",
				"X-Scissor",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}