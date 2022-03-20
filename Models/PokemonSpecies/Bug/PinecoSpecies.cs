using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pineco Species to store common natural stats of all Pinecos
	#region PinecoSpecies
	public class PinecoSpecies : PokemonSpecies
	{
#nullable enable
		private static PinecoSpecies? _instance = null;
#nullable restore
        public static PinecoSpecies Instance => _instance ?? (_instance = new PinecoSpecies());

		#region PinecoSpecies Constructor
		public PinecoSpecies() : base(
			204,
			"Pineco",
			Bug.Instance,
			0.6,
			7.2,
			new PokemonStats(
				50, // HPs
				65, 90, // Attack & Defense
				35, 35, // Spacial Attack & Defense
				15 // Speed
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Pin-Missile",
				"Counter",
				"Strength",
				"Solar-Beam",
				"String-Shot",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Swift",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Spikes",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Rapid-Spin",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Revenge",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Iron-Defense",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Power-Trick",
				"Toxic-Spikes",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}