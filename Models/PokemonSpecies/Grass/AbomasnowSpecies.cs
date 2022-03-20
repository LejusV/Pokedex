using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Abomasnow Species to store common natural stats of all Abomasnows
	#region AbomasnowSpecies
	public class AbomasnowSpecies : PokemonSpecies
	{
#nullable enable
		private static AbomasnowSpecies? _instance = null;
#nullable restore
        public static AbomasnowSpecies Instance => _instance ?? (_instance = new AbomasnowSpecies());

		#region AbomasnowSpecies Constructor
		public AbomasnowSpecies() : base(
			460,
			"Abomasnow",
			Grass.Instance, Ice.Instance,
			2.2,
			135.5,
			new PokemonStats(
				90, // HPs
				92, 75, // Attack & Defense
				92, 85, // Spacial Attack & Defense
				60 // Speed
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
				"Headbutt",
				"Leer",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Razor-Leaf",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Outrage",
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
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Role-Play",
				"Ingrain",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Grass-Whistle",
				"Sheer-Cold",
				"Bullet-Seed",
				"Block",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Worry-Seed",
				"Seed-Bomb",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Rock-Climb",
				"Captivate",
				"Grass-Knot",
				"Wood-Hammer",
				"Round",
				"Bulldoze",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}