using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lugia Species to store common natural stats of all Lugias
	#region LugiaSpecies
	public class LugiaSpecies : PokemonSpecies
	{
#nullable enable
		private static LugiaSpecies? _instance = null;
#nullable restore
        public static LugiaSpecies Instance => _instance ?? (_instance = new LugiaSpecies());

		#region LugiaSpecies Constructor
		public LugiaSpecies() : base(
			249,
			"Lugia",
			Psychic.Instance, Flying.Instance,
			5.2,
			216.0,
			new PokemonStats(
				106, // HPs
				90, 130, // Attack & Defense
				90, 154, // Spacial Attack & Defense
				110 // Speed
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
				"Gust",
				"Whirlwind",
				"Fly",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Waterfall",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Aeroblast",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Trick",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Weather-Ball",
				"Air-Cutter",
				"Signal-Beam",
				"Extrasensory",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Brine",
				"Natural-Gift",
				"Tailwind",
				"Punishment",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Defog",
				"Iron-Head",
				"Charge-Beam",
				"Ominous-Wind",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Echoed-Voice",
				"Sky-Drop",
				"Bulldoze",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}