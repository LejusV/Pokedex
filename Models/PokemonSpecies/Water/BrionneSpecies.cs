using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Brionne Species to store common natural stats of all Brionnes
	#region BrionneSpecies
	public class BrionneSpecies : PokemonSpecies
	{
#nullable enable
		private static BrionneSpecies? _instance = null;
#nullable restore
        public static BrionneSpecies Instance => _instance ?? (_instance = new BrionneSpecies());

		#region BrionneSpecies Constructor
		public BrionneSpecies() : base(
			729,
			"Brionne",
			Water.Instance,
			0.6,
			17.5,
			new PokemonStats(
				60, // HPs
				69, 69, // Attack & Defense
				91, 81, // Spacial Attack & Defense
				50 // Speed
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
				"Pound",
				"Double-Slap",
				"Growl",
				"Sing",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Rest",
				"Substitute",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Hail",
				"Facade",
				"Hyper-Voice",
				"Captivate",
				"Aqua-Jet",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Disarming-Voice",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}