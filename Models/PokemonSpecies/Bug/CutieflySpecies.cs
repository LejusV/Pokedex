using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cutiefly Species to store common natural stats of all Cutieflys
	#region CutieflySpecies
	public class CutieflySpecies : PokemonSpecies
	{
#nullable enable
		private static CutieflySpecies? _instance = null;
#nullable restore
        public static CutieflySpecies Instance => _instance ?? (_instance = new CutieflySpecies());

		#region CutieflySpecies Constructor
		public CutieflySpecies() : base(
			742,
			"Cutiefly",
			Bug.Instance, Fairy.Instance,
			0.1,
			0.2,
			new PokemonStats(
				40, // HPs
				45, 40, // Attack & Defense
				55, 40, // Spacial Attack & Defense
				84 // Speed
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
				"Stun-Spore",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Skill-Swap",
				"Aromatherapy",
				"Silver-Wind",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Bestow",
				"Struggle-Bug",
				"Sticky-Web",
				"Draining-Kiss",
				"Fairy-Wind",
				"Moonblast",
				"Confide",
				"Powder",
				"Dazzling-Gleam",
				"Infestation",
				"Speed-Swap"
			};
		}
		#endregion
	}
	#endregion
}