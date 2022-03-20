using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Spoink Species to store common natural stats of all Spoinks
	#region SpoinkSpecies
	public class SpoinkSpecies : PokemonSpecies
	{
#nullable enable
		private static SpoinkSpecies? _instance = null;
#nullable restore
        public static SpoinkSpecies Instance => _instance ?? (_instance = new SpoinkSpecies());

		#region SpoinkSpecies Constructor
		public SpoinkSpecies() : base(
			325,
			"Spoink",
			Psychic.Instance,
			0.7,
			30.6,
			new PokemonStats(
				60, // HPs
				25, 35, // Attack & Defense
				70, 80, // Spacial Attack & Defense
				60 // Speed
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
				"Whirlwind",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Psybeam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Splash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Facade",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Odor-Sleuth",
				"Signal-Beam",
				"Extrasensory",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Lucky-Chant",
				"Power-Gem",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Simple-Beam",
				"Round",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}