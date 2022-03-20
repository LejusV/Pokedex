using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Manaphy Species to store common natural stats of all Manaphys
	#region ManaphySpecies
	public class ManaphySpecies : PokemonSpecies
	{
#nullable enable
		private static ManaphySpecies? _instance = null;
#nullable restore
        public static ManaphySpecies Instance => _instance ?? (_instance = new ManaphySpecies());

		#region ManaphySpecies Constructor
		public ManaphySpecies() : base(
			490,
			"Manaphy",
			Water.Instance,
			0.3,
			1.4,
			new PokemonStats(
				100, // HPs
				100, 100, // Attack & Defense
				100, 100, // Spacial Attack & Defense
				100 // Speed
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
				"Supersonic",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Waterfall",
				"Swift",
				"Bubble",
				"Flash",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Tail-Glow",
				"Signal-Beam",
				"Bounce",
				"Covet",
				"Water-Sport",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Heart-Swap",
				"Aqua-Ring",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Round",
				"Scald",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}