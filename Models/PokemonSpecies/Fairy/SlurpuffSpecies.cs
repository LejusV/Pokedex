using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Slurpuff Species to store common natural stats of all Slurpuffs
	#region SlurpuffSpecies
	public class SlurpuffSpecies : PokemonSpecies
	{
#nullable enable
		private static SlurpuffSpecies? _instance = null;
#nullable restore
        public static SlurpuffSpecies Instance => _instance ?? (_instance = new SlurpuffSpecies());

		#region SlurpuffSpecies Constructor
		public SlurpuffSpecies() : base(
			685,
			"Slurpuff",
			Fairy.Instance,
			0.8,
			5.0,
			new PokemonStats(
				82, // HPs
				80, 86, // Attack & Defense
				85, 75, // Spacial Attack & Defense
				72 // Speed
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
				"Tackle",
				"Flamethrower",
				"Surf",
				"Hyper-Beam",
				"Thunderbolt",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Helping-Hand",
				"Wish",
				"Magic-Coat",
				"Endeavor",
				"Secret-Power",
				"Aromatherapy",
				"Fake-Tears",
				"Covet",
				"Calm-Mind",
				"Gastro-Acid",
				"Drain-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"After-You",
				"Round",
				"Cotton-Guard",
				"Draining-Kiss",
				"Play-Rough",
				"Fairy-Wind",
				"Play-Nice",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}