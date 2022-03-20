using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Emboar Species to store common natural stats of all Emboars
	#region EmboarSpecies
	public class EmboarSpecies : PokemonSpecies
	{
#nullable enable
		private static EmboarSpecies? _instance = null;
#nullable restore
        public static EmboarSpecies Instance => _instance ?? (_instance = new EmboarSpecies());

		#region EmboarSpecies Constructor
		public EmboarSpecies() : base(
			500,
			"Emboar",
			Fire.Instance, Fighting.Instance,
			1.6,
			150.0,
			new PokemonStats(
				110, // HPs
				123, 65, // Attack & Defense
				100, 65, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Thunder-Punch",
				"Tackle",
				"Take-Down",
				"Tail-Whip",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Smog",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Rollout",
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
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Arm-Thrust",
				"Blast-Burn",
				"Overheat",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Block",
				"Bulk-Up",
				"Covet",
				"Hammer-Arm",
				"Gyro-Ball",
				"Assurance",
				"Fling",
				"Flare-Blitz",
				"Poison-Jab",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Head-Smash",
				"Smack-Down",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Incinerate",
				"Fire-Pledge",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Heat-Crash",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}