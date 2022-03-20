using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hippowdon Species to store common natural stats of all Hippowdons
	#region HippowdonSpecies
	public class HippowdonSpecies : PokemonSpecies
	{
#nullable enable
		private static HippowdonSpecies? _instance = null;
#nullable restore
        public static HippowdonSpecies Instance => _instance ?? (_instance = new HippowdonSpecies());

		#region HippowdonSpecies Constructor
		public HippowdonSpecies() : base(
			450,
			"Hippowdon",
			Ground.Instance,
			2.0,
			300.0,
			new PokemonStats(
				108, // HPs
				112, 118, // Attack & Defense
				68, 72, // Spacial Attack & Defense
				47 // Speed
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Yawn",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Water-Pulse",
				"Natural-Gift",
				"Earth-Power",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}