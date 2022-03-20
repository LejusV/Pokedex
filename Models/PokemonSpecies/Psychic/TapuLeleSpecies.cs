using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tapu-Lele Species to store common natural stats of all Tapu-Leles
	#region Tapu-LeleSpecies
	public class TapuLeleSpecies : PokemonSpecies
	{
#nullable enable
		private static TapuLeleSpecies? _instance = null;
#nullable restore
        public static TapuLeleSpecies Instance => _instance ?? (_instance = new TapuLeleSpecies());

		#region Tapu-LeleSpecies Constructor
		public TapuLeleSpecies() : base(
			786,
			"Tapu-Lele",
			Psychic.Instance, Fairy.Instance,
			1.2,
			18.6,
			new PokemonStats(
				70, // HPs
				85, 75, // Attack & Defense
				130, 115, // Spacial Attack & Defense
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
				"Psybeam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Psywave",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Mean-Look",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Torment",
				"Flatter",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Skill-Swap",
				"Astonish",
				"Aromatherapy",
				"Tickle",
				"Extrasensory",
				"Calm-Mind",
				"Fling",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Round",
				"Echoed-Voice",
				"Draining-Kiss",
				"Moonblast",
				"Confide",
				"Aromatic-Mist",
				"Dazzling-Gleam",
				"Psychic-Terrain",
				"Natures-Madness"
			};
		}
		#endregion
	}
	#endregion
}