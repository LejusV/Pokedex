using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Suicune Species to store common natural stats of all Suicunes
	#region SuicuneSpecies
	public class SuicuneSpecies : PokemonSpecies
	{
#nullable enable
		private static SuicuneSpecies? _instance = null;
#nullable restore
        public static SuicuneSpecies Instance => _instance ?? (_instance = new SuicuneSpecies());

		#region SuicuneSpecies Constructor
		public SuicuneSpecies() : base(
			245,
			"Suicune",
			Water.Instance,
			2.0,
			187.0,
			new PokemonStats(
				100, // HPs
				75, 115, // Attack & Defense
				90, 115, // Spacial Attack & Defense
				85 // Speed
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
				"Cut",
				"Gust",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Waterfall",
				"Swift",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Extrasensory",
				"Sheer-Cold",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Tailwind",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Rock-Climb",
				"Iron-Head",
				"Ominous-Wind",
				"Round",
				"Scald",
				"Quash",
				"Bulldoze",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}