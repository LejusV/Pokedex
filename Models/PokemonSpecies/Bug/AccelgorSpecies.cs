using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Accelgor Species to store common natural stats of all Accelgors
	#region AccelgorSpecies
	public class AccelgorSpecies : PokemonSpecies
	{
#nullable enable
		private static AccelgorSpecies? _instance = null;
#nullable restore
        public static AccelgorSpecies Instance => _instance ?? (_instance = new AccelgorSpecies());

		#region AccelgorSpecies Constructor
		public AccelgorSpecies() : base(
			617,
			"Accelgor",
			Bug.Instance,
			0.8,
			25.3,
			new PokemonStats(
				80, // HPs
				70, 40, // Attack & Defense
				100, 60, // Spacial Attack & Defense
				145 // Speed
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
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Recover",
				"Swift",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Sandstorm",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"U-Turn",
				"Gastro-Acid",
				"Me-First",
				"Power-Swap",
				"Bug-Buzz",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Bug-Bite",
				"Venoshock",
				"Acid-Spray",
				"Round",
				"Final-Gambit",
				"Struggle-Bug",
				"Confide",
				"Water-Shuriken",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}