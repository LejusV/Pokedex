using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dhelmise Species to store common natural stats of all Dhelmises
	#region DhelmiseSpecies
	public class DhelmiseSpecies : PokemonSpecies
	{
#nullable enable
		private static DhelmiseSpecies? _instance = null;
#nullable restore
        public static DhelmiseSpecies Instance => _instance ?? (_instance = new DhelmiseSpecies());

		#region DhelmiseSpecies Constructor
		public DhelmiseSpecies() : base(
			781,
			"Dhelmise",
			Ghost.Instance, Grass.Instance,
			3.9,
			210.0,
			new PokemonStats(
				70, // HPs
				131, 100, // Attack & Defense
				86, 90, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Slam",
				"Wrap",
				"Surf",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Whirlpool",
				"Facade",
				"Brick-Break",
				"Astonish",
				"Metal-Sound",
				"Aerial-Ace",
				"Gyro-Ball",
				"Payback",
				"Embargo",
				"Energy-Ball",
				"Switcheroo",
				"Giga-Impact",
				"Shadow-Claw",
				"Flash-Cannon",
				"Power-Whip",
				"Grass-Knot",
				"Sludge-Wave",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Phantom-Force",
				"Confide",
				"Anchor-Shot",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}