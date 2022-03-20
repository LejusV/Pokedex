using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Xatu Species to store common natural stats of all Xatus
	#region XatuSpecies
	public class XatuSpecies : PokemonSpecies
	{
#nullable enable
		private static XatuSpecies? _instance = null;
#nullable restore
        public static XatuSpecies Instance => _instance ?? (_instance = new XatuSpecies());

		#region XatuSpecies Constructor
		public XatuSpecies() : base(
			178,
			"Xatu",
			Psychic.Instance, Flying.Instance,
			1.5,
			15.0,
			new PokemonStats(
				65, // HPs
				75, 70, // Attack & Defense
				95, 70, // Spacial Attack & Defense
				95 // Speed
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
				"Fly",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Peck",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Teleport",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
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
				"Secret-Power",
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
				"Air-Slash",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Ominous-Wind",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
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