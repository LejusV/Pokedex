using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Darumaka Species to store common natural stats of all Darumakas
	#region DarumakaSpecies
	public class DarumakaSpecies : PokemonSpecies
	{
#nullable enable
		private static DarumakaSpecies? _instance = null;
#nullable restore
        public static DarumakaSpecies Instance => _instance ?? (_instance = new DarumakaSpecies());

		#region DarumakaSpecies Constructor
		public DarumakaSpecies() : base(
			554,
			"Darumaka",
			Fire.Instance,
			0.6,
			37.5,
			new PokemonStats(
				70, // HPs
				90, 45, // Attack & Defense
				15, 45, // Spacial Attack & Defense
				50 // Speed
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
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Thrash",
				"Roar",
				"Flamethrower",
				"Strength",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Rage",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Belly-Drum",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Yawn",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Extrasensory",
				"Hammer-Arm",
				"Gyro-Ball",
				"U-Turn",
				"Fling",
				"Flare-Blitz",
				"Fire-Fang",
				"Zen-Headbutt",
				"Grass-Knot",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}