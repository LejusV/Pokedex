using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shelmet Species to store common natural stats of all Shelmets
	#region ShelmetSpecies
	public class ShelmetSpecies : PokemonSpecies
	{
#nullable enable
		private static ShelmetSpecies? _instance = null;
#nullable restore
        public static ShelmetSpecies Instance => _instance ?? (_instance = new ShelmetSpecies());

		#region ShelmetSpecies Constructor
		public ShelmetSpecies() : base(
			616,
			"Shelmet",
			Bug.Instance,
			0.4,
			7.7,
			new PokemonStats(
				50, // HPs
				40, 85, // Attack & Defense
				40, 65, // Spacial Attack & Defense
				25 // Speed
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
				"Body-Slam",
				"Double-Edge",
				"Acid",
				"Absorb",
				"Mega-Drain",
				"Toxic",
				"Double-Team",
				"Recover",
				"Bide",
				"Leech-Life",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Spikes",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Encore",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Signal-Beam",
				"Feint",
				"Gastro-Acid",
				"Guard-Swap",
				"Toxic-Spikes",
				"Bug-Buzz",
				"Energy-Ball",
				"Bug-Bite",
				"Guard-Split",
				"Venoshock",
				"Round",
				"Final-Gambit",
				"Struggle-Bug",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}