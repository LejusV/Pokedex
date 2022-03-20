using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Azelf Species to store common natural stats of all Azelfs
	#region AzelfSpecies
	public class AzelfSpecies : PokemonSpecies
	{
#nullable enable
		private static AzelfSpecies? _instance = null;
#nullable restore
        public static AzelfSpecies Instance => _instance ?? (_instance = new AzelfSpecies());

		#region AzelfSpecies Constructor
		public AzelfSpecies() : base(
			482,
			"Azelf",
			Psychic.Instance,
			0.3,
			0.3,
			new PokemonStats(
				75, // HPs
				125, 70, // Attack & Defense
				125, 70, // Spacial Attack & Defense
				115 // Speed
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
				"Flamethrower",
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
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
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
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
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
				"Natural-Gift",
				"U-Turn",
				"Payback",
				"Fling",
				"Last-Resort",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
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
				"Incinerate",
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