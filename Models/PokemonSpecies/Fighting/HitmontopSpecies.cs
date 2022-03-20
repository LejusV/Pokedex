using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hitmontop Species to store common natural stats of all Hitmontops
	#region HitmontopSpecies
	public class HitmontopSpecies : PokemonSpecies
	{
#nullable enable
		private static HitmontopSpecies? _instance = null;
#nullable restore
        public static HitmontopSpecies Instance => _instance ?? (_instance = new HitmontopSpecies());

		#region HitmontopSpecies Constructor
		public HitmontopSpecies() : base(
			237,
			"Hitmontop",
			Fighting.Instance,
			1.4,
			48.0,
			new PokemonStats(
				50, // HPs
				95, 95, // Attack & Defense
				35, 110, // Spacial Attack & Defense
				70 // Speed
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
				"Rolling-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Triple-Kick",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Rapid-Spin",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Helping-Hand",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Gyro-Ball",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Sucker-Punch",
				"Vacuum-Wave",
				"Stone-Edge",
				"Captivate",
				"Wide-Guard",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}