using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ralts Species to store common natural stats of all Raltss
	#region RaltsSpecies
	public class RaltsSpecies : PokemonSpecies
	{
#nullable enable
		private static RaltsSpecies? _instance = null;
#nullable restore
        public static RaltsSpecies Instance => _instance ?? (_instance = new RaltsSpecies());

		#region RaltsSpecies Constructor
		public RaltsSpecies() : base(
			280,
			"Ralts",
			Psychic.Instance, Fairy.Instance,
			0.4,
			6.6,
			new PokemonStats(
				28, // HPs
				25, 25, // Attack & Defense
				45, 35, // Spacial Attack & Defense
				40 // Speed
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
				"Disable",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
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
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Grudge",
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
				"Shadow-Sneak",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Ally-Switch",
				"Heal-Pulse",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}