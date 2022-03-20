using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Scraggy Species to store common natural stats of all Scraggys
	#region ScraggySpecies
	public class ScraggySpecies : PokemonSpecies
	{
#nullable enable
		private static ScraggySpecies? _instance = null;
#nullable restore
        public static ScraggySpecies Instance => _instance ?? (_instance = new ScraggySpecies());

		#region ScraggySpecies Constructor
		public ScraggySpecies() : base(
			559,
			"Scraggy",
			Dark.Instance, Fighting.Instance,
			0.6,
			11.8,
			new PokemonStats(
				50, // HPs
				75, 70, // Attack & Defense
				35, 70, // Spacial Attack & Defense
				48 // Speed
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
				"Low-Kick",
				"Counter",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Amnesia",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sludge-Bomb",
				"Detect",
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
				"Fake-Out",
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
				"Dragon-Dance",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Head-Smash",
				"Smack-Down",
				"Low-Sweep",
				"Acid-Spray",
				"Foul-Play",
				"Round",
				"Chip-Away",
				"Quick-Guard",
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