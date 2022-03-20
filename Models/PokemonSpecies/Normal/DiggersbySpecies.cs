using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Diggersby Species to store common natural stats of all Diggersbys
	#region DiggersbySpecies
	public class DiggersbySpecies : PokemonSpecies
	{
#nullable enable
		private static DiggersbySpecies? _instance = null;
#nullable restore
        public static DiggersbySpecies Instance => _instance ?? (_instance = new DiggersbySpecies());

		#region DiggersbySpecies Constructor
		public DiggersbySpecies() : base(
			660,
			"Diggersby",
			Normal.Instance, Ground.Instance,
			1.0,
			42.4,
			new PokemonStats(
				85, // HPs
				56, 77, // Attack & Defense
				50, 77, // Spacial Attack & Defense
				78 // Speed
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
				"Double-Slap",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Double-Kick",
				"Tackle",
				"Take-Down",
				"Leer",
				"Surf",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Superpower",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Bulk-Up",
				"Bounce",
				"Mud-Shot",
				"Hammer-Arm",
				"U-Turn",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Last-Resort",
				"Earth-Power",
				"Giga-Impact",
				"Gunk-Shot",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Smack-Down",
				"Foul-Play",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Rototiller",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}