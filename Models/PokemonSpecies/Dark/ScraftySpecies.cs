using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Scrafty Species to store common natural stats of all Scraftys
	#region ScraftySpecies
	public class ScraftySpecies : PokemonSpecies
	{
#nullable enable
		private static ScraftySpecies? _instance = null;
#nullable restore
        public static ScraftySpecies Instance => _instance ?? (_instance = new ScraftySpecies());

		#region ScraftySpecies Constructor
		public ScraftySpecies() : base(
			560,
			"Scrafty",
			Dark.Instance, Fighting.Instance,
			1.1,
			30.0,
			new PokemonStats(
				65, // HPs
				90, 115, // Attack & Defense
				45, 115, // Spacial Attack & Defense
				58 // Speed
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
				"Sand-Attack",
				"Headbutt",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sludge-Bomb",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Head-Smash",
				"Smack-Down",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Dragon-Tail",
				"Work-Up",
				"Dual-Chop",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}