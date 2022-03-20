using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Swirlix Species to store common natural stats of all Swirlixs
	#region SwirlixSpecies
	public class SwirlixSpecies : PokemonSpecies
	{
#nullable enable
		private static SwirlixSpecies? _instance = null;
#nullable restore
        public static SwirlixSpecies Instance => _instance ?? (_instance = new SwirlixSpecies());

		#region SwirlixSpecies Constructor
		public SwirlixSpecies() : base(
			684,
			"Swirlix",
			Fairy.Instance,
			0.4,
			3.5,
			new PokemonStats(
				62, // HPs
				48, 66, // Attack & Defense
				59, 57, // Spacial Attack & Defense
				49 // Speed
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
				"Belly-Drum",
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
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Aromatherapy",
				"Fake-Tears",
				"Covet",
				"Calm-Mind",
				"Gastro-Acid",
				"Copycat",
				"Energy-Ball",
				"After-You",
				"Round",
				"Cotton-Guard",
				"Sticky-Web",
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