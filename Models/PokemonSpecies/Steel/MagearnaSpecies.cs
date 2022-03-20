using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Magearna Species to store common natural stats of all Magearnas
	#region MagearnaSpecies
	public class MagearnaSpecies : PokemonSpecies
	{
#nullable enable
		private static MagearnaSpecies? _instance = null;
#nullable restore
        public static MagearnaSpecies Instance => _instance ?? (_instance = new MagearnaSpecies());

		#region MagearnaSpecies Constructor
		public MagearnaSpecies() : base(
			801,
			"Magearna",
			Steel.Instance, Fairy.Instance,
			1.0,
			80.5,
			new PokemonStats(
				80, // HPs
				95, 115, // Attack & Defense
				130, 115, // Spacial Attack & Defense
				65 // Speed
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
				"Sonic-Boom",
				"Ice-Beam",
				"Psybeam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Explosion",
				"Substitute",
				"Mind-Reader",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Shadow-Ball",
				"Helping-Hand",
				"Brick-Break",
				"Iron-Defense",
				"Calm-Mind",
				"Gyro-Ball",
				"Embargo",
				"Trump-Card",
				"Lucky-Chant",
				"Heart-Swap",
				"Aura-Sphere",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Mirror-Shot",
				"Flash-Cannon",
				"Trick-Room",
				"Iron-Head",
				"Grass-Knot",
				"Charge-Beam",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Shift-Gear",
				"Volt-Switch",
				"Crafty-Shield",
				"Confide",
				"Dazzling-Gleam",
				"Gear-Up",
				"Fleur-Cannon"
			};
		}
		#endregion
	}
	#endregion
}