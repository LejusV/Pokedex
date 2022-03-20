using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sandygast Species to store common natural stats of all Sandygasts
	#region SandygastSpecies
	public class SandygastSpecies : PokemonSpecies
	{
#nullable enable
		private static SandygastSpecies? _instance = null;
#nullable restore
        public static SandygastSpecies Instance => _instance ?? (_instance = new SandygastSpecies());

		#region SandygastSpecies Constructor
		public SandygastSpecies() : base(
			769,
			"Sandygast",
			Ghost.Instance, Ground.Instance,
			0.5,
			70.0,
			new PokemonStats(
				55, // HPs
				55, 80, // Attack & Defense
				70, 45, // Spacial Attack & Defense
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
				"Sand-Attack",
				"Absorb",
				"Mega-Drain",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Harden",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Curse",
				"Protect",
				"Destiny-Bond",
				"Sandstorm",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Ancient-Power",
				"Shadow-Ball",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Astonish",
				"Rock-Tomb",
				"Sand-Tomb",
				"Iron-Defense",
				"Rock-Polish",
				"Energy-Ball",
				"Earth-Power",
				"Stone-Edge",
				"Round",
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