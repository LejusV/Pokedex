using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Morelull Species to store common natural stats of all Morelulls
	#region MorelullSpecies
	public class MorelullSpecies : PokemonSpecies
	{
#nullable enable
		private static MorelullSpecies? _instance = null;
#nullable restore
        public static MorelullSpecies Instance => _instance ?? (_instance = new MorelullSpecies());

		#region MorelullSpecies Constructor
		public MorelullSpecies() : base(
			755,
			"Morelull",
			Grass.Instance, Fairy.Instance,
			0.2,
			1.5,
			new PokemonStats(
				40, // HPs
				35, 55, // Attack & Defense
				65, 75, // Spacial Attack & Defense
				15 // Speed
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
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Thunder-Wave",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Amnesia",
				"Dream-Eater",
				"Spore",
				"Flash",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Nature-Power",
				"Ingrain",
				"Astonish",
				"Energy-Ball",
				"Grass-Knot",
				"Round",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Strength-Sap",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion
}