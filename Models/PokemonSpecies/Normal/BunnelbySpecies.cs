using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bunnelby Species to store common natural stats of all Bunnelbys
	#region BunnelbySpecies
	public class BunnelbySpecies : PokemonSpecies
	{
#nullable enable
		private static BunnelbySpecies? _instance = null;
#nullable restore
        public static BunnelbySpecies Instance => _instance ?? (_instance = new BunnelbySpecies());

		#region BunnelbySpecies Constructor
		public BunnelbySpecies() : base(
			659,
			"Bunnelby",
			Normal.Instance,
			0.4,
			5.0,
			new PokemonStats(
				38, // HPs
				36, 38, // Attack & Defense
				32, 36, // Spacial Attack & Defense
				57 // Speed
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
				"Double-Slap",
				"Cut",
				"Double-Kick",
				"Tackle",
				"Take-Down",
				"Leer",
				"Surf",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Spikes",
				"Sandstorm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Nature-Power",
				"Recycle",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Bulk-Up",
				"Bounce",
				"Mud-Shot",
				"U-Turn",
				"Payback",
				"Fling",
				"Last-Resort",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Smack-Down",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}