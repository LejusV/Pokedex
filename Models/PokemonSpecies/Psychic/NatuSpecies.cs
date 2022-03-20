using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Natu Species to store common natural stats of all Natus
	#region NatuSpecies
	public class NatuSpecies : PokemonSpecies
	{
#nullable enable
		private static NatuSpecies? _instance = null;
#nullable restore
        public static NatuSpecies Instance => _instance ?? (_instance = new NatuSpecies());

		#region NatuSpecies Constructor
		public NatuSpecies() : base(
			177,
			"Natu",
			Psychic.Instance, Flying.Instance,
			0.2,
			2.0,
			new PokemonStats(
				40, // HPs
				50, 45, // Attack & Defense
				70, 45, // Spacial Attack & Defense
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
				"Double-Edge",
				"Leer",
				"Peck",
				"Drill-Peck",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Teleport",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Haze",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Heat-Wave",
				"Facade",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Skill-Swap",
				"Refresh",
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Miracle-Eye",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Psycho-Shift",
				"Lucky-Chant",
				"Me-First",
				"Power-Swap",
				"Guard-Swap",
				"Sucker-Punch",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Ominous-Wind",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Synchronoise",
				"Simple-Beam",
				"Round",
				"Stored-Power",
				"Ally-Switch",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}