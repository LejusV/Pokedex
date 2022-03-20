using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Marshadow Species to store common natural stats of all Marshadows
	#region MarshadowSpecies
	public class MarshadowSpecies : PokemonSpecies
	{
#nullable enable
		private static MarshadowSpecies? _instance = null;
#nullable restore
        public static MarshadowSpecies Instance => _instance ?? (_instance = new MarshadowSpecies());

		#region MarshadowSpecies Constructor
		public MarshadowSpecies() : base(
			802,
			"Marshadow",
			Fighting.Instance, Ghost.Instance,
			0.7,
			22.2,
			new PokemonStats(
				90, // HPs
				125, 80, // Attack & Defense
				90, 90, // Spacial Attack & Defense
				125 // Speed
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
				"Jump-Kick",
				"Rolling-Kick",
				"Counter",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Psych-Up",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Facade",
				"Role-Play",
				"Brick-Break",
				"Endeavor",
				"Rock-Tomb",
				"Shadow-Punch",
				"Bulk-Up",
				"Calm-Mind",
				"Feint",
				"Close-Combat",
				"Payback",
				"Assurance",
				"Fling",
				"Copycat",
				"Sucker-Punch",
				"Force-Palm",
				"Poison-Jab",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Stone-Edge",
				"Grass-Knot",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Work-Up",
				"Confide",
				"Laser-Focus",
				"Spectral-Thief"
			};
		}
		#endregion
	}
	#endregion
}