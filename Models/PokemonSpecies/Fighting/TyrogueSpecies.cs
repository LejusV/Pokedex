using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tyrogue Species to store common natural stats of all Tyrogues
	#region TyrogueSpecies
	public class TyrogueSpecies : PokemonSpecies
	{
#nullable enable
		private static TyrogueSpecies? _instance = null;
#nullable restore
        public static TyrogueSpecies Instance => _instance ?? (_instance = new TyrogueSpecies());

		#region TyrogueSpecies Constructor
		public TyrogueSpecies() : base(
			236,
			"Tyrogue",
			Fighting.Instance,
			0.7,
			21.0,
			new PokemonStats(
				35, // HPs
				35, 35, // Attack & Defense
				35, 35, // Spacial Attack & Defense
				35 // Speed
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
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Swift",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Protect",
				"Mach-Punch",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"Feint",
				"Vacuum-Wave",
				"Bullet-Punch",
				"Captivate",
				"Low-Sweep",
				"Round",
				"Ally-Switch",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}