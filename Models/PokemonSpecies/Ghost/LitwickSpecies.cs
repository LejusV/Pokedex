using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Litwick Species to store common natural stats of all Litwicks
	#region LitwickSpecies
	public class LitwickSpecies : PokemonSpecies
	{
#nullable enable
		private static LitwickSpecies? _instance = null;
#nullable restore
        public static LitwickSpecies Instance => _instance ?? (_instance = new LitwickSpecies());

		#region LitwickSpecies Constructor
		public LitwickSpecies() : base(
			607,
			"Litwick",
			Ghost.Instance, Fire.Instance,
			0.3,
			3.1,
			new PokemonStats(
				50, // HPs
				30, 55, // Attack & Defense
				65, 55, // Spacial Attack & Defense
				20 // Speed
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
				"Acid",
				"Ember",
				"Flamethrower",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Minimize",
				"Confuse-Ray",
				"Haze",
				"Smog",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Endure",
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
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Imprison",
				"Secret-Power",
				"Astonish",
				"Overheat",
				"Calm-Mind",
				"Shock-Wave",
				"Payback",
				"Embargo",
				"Dark-Pulse",
				"Energy-Ball",
				"Trick-Room",
				"Captivate",
				"Power-Split",
				"Telekinesis",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Clear-Smog",
				"Hex",
				"Incinerate",
				"Inferno",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}