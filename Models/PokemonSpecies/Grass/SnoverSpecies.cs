using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Snover Species to store common natural stats of all Snovers
	#region SnoverSpecies
	public class SnoverSpecies : PokemonSpecies
	{
#nullable enable
		private static SnoverSpecies? _instance = null;
#nullable restore
        public static SnoverSpecies Instance => _instance ?? (_instance = new SnoverSpecies());

		#region SnoverSpecies Constructor
		public SnoverSpecies() : base(
			459,
			"Snover",
			Grass.Instance, Ice.Instance,
			1.0,
			50.5,
			new PokemonStats(
				60, // HPs
				62, 50, // Attack & Defense
				62, 60, // Spacial Attack & Defense
				40 // Speed
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
				"Ice-Punch",
				"Swords-Dance",
				"Stomp",
				"Headbutt",
				"Double-Edge",
				"Leer",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Role-Play",
				"Ingrain",
				"Secret-Power",
				"Grass-Whistle",
				"Sheer-Cold",
				"Bullet-Seed",
				"Magical-Leaf",
				"Water-Pulse",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Avalanche",
				"Ice-Shard",
				"Captivate",
				"Grass-Knot",
				"Wood-Hammer",
				"Round",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}