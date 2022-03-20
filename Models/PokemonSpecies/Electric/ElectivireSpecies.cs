using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Electivire Species to store common natural stats of all Electivires
	#region ElectivireSpecies
	public class ElectivireSpecies : PokemonSpecies
	{
#nullable enable
		private static ElectivireSpecies? _instance = null;
#nullable restore
        public static ElectivireSpecies Instance => _instance ?? (_instance = new ElectivireSpecies());

		#region ElectivireSpecies Constructor
		public ElectivireSpecies() : base(
			466,
			"Electivire",
			Electric.Instance,
			1.8,
			138.6,
			new PokemonStats(
				75, // HPs
				123, 67, // Attack & Defense
				95, 85, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Leer",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"Low-Sweep",
				"Round",
				"Volt-Switch",
				"Bulldoze",
				"Electroweb",
				"Wild-Charge",
				"Dual-Chop",
				"Ion-Deluge",
				"Confide",
				"Electric-Terrain",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}