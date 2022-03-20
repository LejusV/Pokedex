using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hoopa Species to store common natural stats of all Hoopas
	#region HoopaSpecies
	public class HoopaSpecies : PokemonSpecies
	{
#nullable enable
		private static HoopaSpecies? _instance = null;
#nullable restore
        public static HoopaSpecies Instance => _instance ?? (_instance = new HoopaSpecies());

		#region HoopaSpecies Constructor
		public HoopaSpecies() : base(
			720,
			"Hoopa",
			Psychic.Instance, Ghost.Instance,
			0.5,
			9.0,
			new PokemonStats(
				80, // HPs
				110, 60, // Attack & Defense
				150, 130, // Spacial Attack & Defense
				70 // Speed
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
				"Psybeam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Destiny-Bond",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Signal-Beam",
				"Block",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Embargo",
				"Fling",
				"Last-Resort",
				"Dark-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Gunk-Shot",
				"Grass-Knot",
				"Charge-Beam",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Ally-Switch",
				"Quash",
				"Dual-Chop",
				"Phantom-Force",
				"Confide",
				"Hyperspace-Hole",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}