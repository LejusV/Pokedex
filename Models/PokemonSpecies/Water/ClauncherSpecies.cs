using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Clauncher Species to store common natural stats of all Claunchers
	#region ClauncherSpecies
	public class ClauncherSpecies : PokemonSpecies
	{
#nullable enable
		private static ClauncherSpecies? _instance = null;
#nullable restore
        public static ClauncherSpecies Instance => _instance ?? (_instance = new ClauncherSpecies());

		#region ClauncherSpecies Constructor
		public ClauncherSpecies() : base(
			692,
			"Clauncher",
			Water.Instance,
			0.5,
			8.3,
			new PokemonStats(
				50, // HPs
				53, 62, // Attack & Defense
				58, 63, // Spacial Attack & Defense
				44 // Speed
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
				"Vice-Grip",
				"Swords-Dance",
				"Cut",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Bubble",
				"Splash",
				"Crabhammer",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Dive",
				"Muddy-Water",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"U-Turn",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Flash-Cannon",
				"Aqua-Jet",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"Entrainment",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}