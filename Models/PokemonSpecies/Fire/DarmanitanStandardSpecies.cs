using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Darmanitan-Standard Species to store common natural stats of all Darmanitan-Standards
	#region Darmanitan-StandardSpecies
	public class DarmanitanStandardSpecies : PokemonSpecies
	{
#nullable enable
		private static DarmanitanStandardSpecies? _instance = null;
#nullable restore
        public static DarmanitanStandardSpecies Instance => _instance ?? (_instance = new DarmanitanStandardSpecies());

		#region Darmanitan-StandardSpecies Constructor
		public DarmanitanStandardSpecies() : base(
			555,
			"Darmanitan-Standard",
			Fire.Instance,
			1.3,
			92.9,
			new PokemonStats(
				105, // HPs
				140, 55, // Attack & Defense
				30, 55, // Spacial Attack & Defense
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
				"Headbutt",
				"Tackle",
				"Thrash",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Psychic",
				"Rage",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Belly-Drum",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Bulk-Up",
				"Hammer-Arm",
				"Gyro-Ball",
				"U-Turn",
				"Payback",
				"Fling",
				"Flare-Blitz",
				"Focus-Blast",
				"Giga-Impact",
				"Fire-Fang",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Smack-Down",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}