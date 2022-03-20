using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mesprit Species to store common natural stats of all Mesprits
	#region MespritSpecies
	public class MespritSpecies : PokemonSpecies
	{
#nullable enable
		private static MespritSpecies? _instance = null;
#nullable restore
        public static MespritSpecies Instance => _instance ?? (_instance = new MespritSpecies());

		#region MespritSpecies Constructor
		public MespritSpecies() : base(
			481,
			"Mesprit",
			Psychic.Instance,
			0.3,
			0.3,
			new PokemonStats(
				80, // HPs
				105, 105, // Attack & Defense
				105, 105, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
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
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Charm",
				"Swagger",
				"Sleep-Talk",
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
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Knock-Off",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Signal-Beam",
				"Extrasensory",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Healing-Wish",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Lucky-Chant",
				"Copycat",
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