using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kirlia Species to store common natural stats of all Kirlias
	#region KirliaSpecies
	public class KirliaSpecies : PokemonSpecies
	{
#nullable enable
		private static KirliaSpecies? _instance = null;
#nullable restore
        public static KirliaSpecies Instance => _instance ?? (_instance = new KirliaSpecies());

		#region KirliaSpecies Constructor
		public KirliaSpecies() : base(
			281,
			"Kirlia",
			Psychic.Instance, Fairy.Instance,
			0.8,
			20.2,
			new PokemonStats(
				38, // HPs
				35, 35, // Attack & Defense
				65, 55, // Spacial Attack & Defense
				50 // Speed
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
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Magical-Leaf",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Lucky-Chant",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Ally-Switch",
				"Heal-Pulse",
				"Disarming-Voice",
				"Draining-Kiss",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}