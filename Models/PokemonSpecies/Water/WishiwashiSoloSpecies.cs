using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wishiwashi-Solo Species to store common natural stats of all Wishiwashi-Solos
	#region Wishiwashi-SoloSpecies
	public class WishiwashiSoloSpecies : PokemonSpecies
	{
#nullable enable
		private static WishiwashiSoloSpecies? _instance = null;
#nullable restore
        public static WishiwashiSoloSpecies Instance => _instance ?? (_instance = new WishiwashiSoloSpecies());

		#region Wishiwashi-SoloSpecies Constructor
		public WishiwashiSoloSpecies() : base(
			746,
			"Wishiwashi-Solo",
			Water.Instance,
			0.2,
			0.3,
			new PokemonStats(
				45, // HPs
				20, 20, // Attack & Defense
				25, 25, // Spacial Attack & Defense
				40 // Speed
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
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Rest",
				"Substitute",
				"Protect",
				"Feint-Attack",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Beat-Up",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Endeavor",
				"Dive",
				"Muddy-Water",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"U-Turn",
				"Aqua-Ring",
				"Aqua-Tail",
				"Soak",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion
}