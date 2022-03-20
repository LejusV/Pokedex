using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chandelure Species to store common natural stats of all Chandelures
	#region ChandelureSpecies
	public class ChandelureSpecies : PokemonSpecies
	{
#nullable enable
		private static ChandelureSpecies? _instance = null;
#nullable restore
        public static ChandelureSpecies Instance => _instance ?? (_instance = new ChandelureSpecies());

		#region ChandelureSpecies Constructor
		public ChandelureSpecies() : base(
			609,
			"Chandelure",
			Ghost.Instance, Fire.Instance,
			1.0,
			34.3,
			new PokemonStats(
				60, // HPs
				55, 90, // Attack & Defense
				145, 90, // Spacial Attack & Defense
				80 // Speed
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
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Confuse-Ray",
				"Smog",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Secret-Power",
				"Overheat",
				"Calm-Mind",
				"Shock-Wave",
				"Payback",
				"Embargo",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Trick-Room",
				"Telekinesis",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Hex",
				"Incinerate",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}