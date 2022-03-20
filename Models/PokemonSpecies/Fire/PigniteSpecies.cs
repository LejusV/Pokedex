using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pignite Species to store common natural stats of all Pignites
	#region PigniteSpecies
	public class PigniteSpecies : PokemonSpecies
	{
#nullable enable
		private static PigniteSpecies? _instance = null;
#nullable restore
        public static PigniteSpecies Instance => _instance ?? (_instance = new PigniteSpecies());

		#region PigniteSpecies Constructor
		public PigniteSpecies() : base(
			499,
			"Pignite",
			Fire.Instance, Fighting.Instance,
			1.0,
			55.5,
			new PokemonStats(
				90, // HPs
				93, 55, // Attack & Defense
				70, 55, // Spacial Attack & Defense
				55 // Speed
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
				"Low-Kick",
				"Strength",
				"Solar-Beam",
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
				"Overheat",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Covet",
				"Gyro-Ball",
				"Assurance",
				"Fling",
				"Flare-Blitz",
				"Poison-Jab",
				"Focus-Blast",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Head-Smash",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
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