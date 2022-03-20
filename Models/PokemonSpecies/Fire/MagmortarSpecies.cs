using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Magmortar Species to store common natural stats of all Magmortars
	#region MagmortarSpecies
	public class MagmortarSpecies : PokemonSpecies
	{
#nullable enable
		private static MagmortarSpecies? _instance = null;
#nullable restore
        public static MagmortarSpecies Instance => _instance ?? (_instance = new MagmortarSpecies());

		#region MagmortarSpecies Constructor
		public MagmortarSpecies() : base(
			467,
			"Magmortar",
			Fire.Instance,
			1.6,
			68.0,
			new PokemonStats(
				75, // HPs
				95, 67, // Attack & Defense
				125, 95, // Spacial Attack & Defense
				83 // Speed
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
				"Thunder-Punch",
				"Headbutt",
				"Leer",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Thunderbolt",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Smokescreen",
				"Confuse-Ray",
				"Smog",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Covet",
				"Natural-Gift",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Lava-Plume",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Bulldoze",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}