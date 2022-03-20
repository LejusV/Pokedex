using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Turtonator Species to store common natural stats of all Turtonators
	#region TurtonatorSpecies
	public class TurtonatorSpecies : PokemonSpecies
	{
#nullable enable
		private static TurtonatorSpecies? _instance = null;
#nullable restore
        public static TurtonatorSpecies Instance => _instance ?? (_instance = new TurtonatorSpecies());

		#region TurtonatorSpecies Constructor
		public TurtonatorSpecies() : base(
			776,
			"Turtonator",
			Fire.Instance, Dragon.Instance,
			2.0,
			212.0,
			new PokemonStats(
				60, // HPs
				78, 135, // Attack & Defense
				91, 85, // Spacial Attack & Defense
				36 // Speed
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
				"Tackle",
				"Body-Slam",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Fire-Spin",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Smog",
				"Fire-Blast",
				"Explosion",
				"Rest",
				"Substitute",
				"Flail",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Revenge",
				"Overheat",
				"Rock-Tomb",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Payback",
				"Fling",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Flash-Cannon",
				"Draco-Meteor",
				"Stone-Edge",
				"Charge-Beam",
				"Head-Smash",
				"Wide-Guard",
				"Venoshock",
				"Smack-Down",
				"Flame-Charge",
				"Round",
				"Shell-Smash",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Confide",
				"Brutal-Swing",
				"Shell-Trap"
			};
		}
		#endregion
	}
	#endregion
}