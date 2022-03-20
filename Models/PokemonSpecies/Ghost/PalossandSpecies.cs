using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Palossand Species to store common natural stats of all Palossands
	#region PalossandSpecies
	public class PalossandSpecies : PokemonSpecies
	{
#nullable enable
		private static PalossandSpecies? _instance = null;
#nullable restore
        public static PalossandSpecies Instance => _instance ?? (_instance = new PalossandSpecies());

		#region PalossandSpecies Constructor
		public PalossandSpecies() : base(
			770,
			"Palossand",
			Ghost.Instance, Ground.Instance,
			1.3,
			250.0,
			new PokemonStats(
				85, // HPs
				75, 110, // Attack & Defense
				100, 75, // Spacial Attack & Defense
				35 // Speed
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
				"Absorb",
				"Mega-Drain",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Harden",
				"Rest",
				"Rock-Slide",
				"Substitute",
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
				"Shadow-Ball",
				"Facade",
				"Astonish",
				"Rock-Tomb",
				"Sand-Tomb",
				"Iron-Defense",
				"Embargo",
				"Fling",
				"Rock-Polish",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Stone-Edge",
				"Round",
				"Quash",
				"Bulldoze",
				"Confide",
				"Infestation",
				"Shore-Up"
			};
		}
		#endregion
	}
	#endregion
}