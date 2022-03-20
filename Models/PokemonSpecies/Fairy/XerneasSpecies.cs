using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Xerneas Species to store common natural stats of all Xerneass
	#region XerneasSpecies
	public class XerneasSpecies : PokemonSpecies
	{
#nullable enable
		private static XerneasSpecies? _instance = null;
#nullable restore
        public static XerneasSpecies Instance => _instance ?? (_instance = new XerneasSpecies());

		#region XerneasSpecies Constructor
		public XerneasSpecies() : base(
			716,
			"Xerneas",
			Fairy.Instance,
			3.0,
			215.0,
			new PokemonStats(
				126, // HPs
				131, 95, // Attack & Defense
				131, 98, // Spacial Attack & Defense
				99 // Speed
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
				"Take-Down",
				"Roar",
				"Aurora-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Outrage",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Hail",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Aromatherapy",
				"Block",
				"Calm-Mind",
				"Gravity",
				"Close-Combat",
				"Night-Slash",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Horn-Leech",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Geomancy",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}