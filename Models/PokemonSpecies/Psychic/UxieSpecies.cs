using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Uxie Species to store common natural stats of all Uxies
	#region UxieSpecies
	public class UxieSpecies : PokemonSpecies
	{
#nullable enable
		private static UxieSpecies? _instance = null;
#nullable restore
        public static UxieSpecies Instance => _instance ?? (_instance = new UxieSpecies());

		#region UxieSpecies Constructor
		public UxieSpecies() : base(
			480,
			"Uxie",
			Psychic.Instance,
			0.3,
			0.3,
			new PokemonStats(
				75, // HPs
				75, 130, // Attack & Defense
				75, 130, // Spacial Attack & Defense
				95 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Memento",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Yawn",
				"Knock-Off",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Signal-Beam",
				"Extrasensory",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Acrobatics",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}