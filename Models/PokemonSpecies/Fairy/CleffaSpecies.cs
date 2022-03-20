using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cleffa Species to store common natural stats of all Cleffas
	#region CleffaSpecies
	public class CleffaSpecies : PokemonSpecies
	{
#nullable enable
		private static CleffaSpecies? _instance = null;
#nullable restore
        public static CleffaSpecies Instance => _instance ?? (_instance = new CleffaSpecies());

		#region CleffaSpecies Constructor
		public CleffaSpecies() : base(
			173,
			"Cleffa",
			Fairy.Instance,
			0.3,
			3.0,
			new PokemonStats(
				50, // HPs
				25, 28, // Attack & Defense
				45, 55, // Spacial Attack & Defense
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
				"Pound",
				"Mega-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Sing",
				"Flamethrower",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Fire-Blast",
				"Amnesia",
				"Soft-Boiled",
				"Dream-Eater",
				"Flash",
				"Splash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Sweet-Kiss",
				"Belly-Drum",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Present",
				"Frustration",
				"Safeguard",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Aromatherapy",
				"Fake-Tears",
				"Tickle",
				"Signal-Beam",
				"Covet",
				"Magical-Leaf",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Last-Resort",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Heal-Pulse",
				"Incinerate",
				"Work-Up",
				"Misty-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}