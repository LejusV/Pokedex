using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Phione Species to store common natural stats of all Phiones
	#region PhioneSpecies
	public class PhioneSpecies : PokemonSpecies
	{
#nullable enable
		private static PhioneSpecies? _instance = null;
#nullable restore
        public static PhioneSpecies Instance => _instance ?? (_instance = new PhioneSpecies());

		#region PhioneSpecies Constructor
		public PhioneSpecies() : base(
			489,
			"Phione",
			Water.Instance,
			0.4,
			3.1,
			new PokemonStats(
				80, // HPs
				80, 80, // Attack & Defense
				80, 80, // Spacial Attack & Defense
				80 // Speed
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
				"Supersonic",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Bubble",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Aqua-Ring",
				"Grass-Knot",
				"Round",
				"Scald",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}