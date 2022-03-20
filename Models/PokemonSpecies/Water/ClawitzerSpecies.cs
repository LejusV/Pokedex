using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Clawitzer Species to store common natural stats of all Clawitzers
	#region ClawitzerSpecies
	public class ClawitzerSpecies : PokemonSpecies
	{
#nullable enable
		private static ClawitzerSpecies? _instance = null;
#nullable restore
        public static ClawitzerSpecies Instance => _instance ?? (_instance = new ClawitzerSpecies());

		#region ClawitzerSpecies Constructor
		public ClawitzerSpecies() : base(
			693,
			"Clawitzer",
			Water.Instance,
			1.3,
			35.3,
			new PokemonStats(
				71, // HPs
				73, 88, // Attack & Defense
				120, 89, // Spacial Attack & Defense
				59 // Speed
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
				"Hyper-Beam",
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
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Shadow-Ball",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Dive",
				"Muddy-Water",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"U-Turn",
				"Aura-Sphere",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Flash-Cannon",
				"Aqua-Jet",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Heal-Pulse",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}