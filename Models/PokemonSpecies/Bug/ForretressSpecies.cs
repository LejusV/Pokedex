using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Forretress Species to store common natural stats of all Forretresss
	#region ForretressSpecies
	public class ForretressSpecies : PokemonSpecies
	{
#nullable enable
		private static ForretressSpecies? _instance = null;
#nullable restore
        public static ForretressSpecies Instance => _instance ?? (_instance = new ForretressSpecies());

		#region ForretressSpecies Constructor
		public ForretressSpecies() : base(
			205,
			"Forretress",
			Bug.Instance, Steel.Instance,
			1.2,
			125.8,
			new PokemonStats(
				75, // HPs
				90, 140, // Attack & Defense
				60, 60, // Spacial Attack & Defense
				40 // Speed
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
				"Hyper-Beam",
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
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Spikes",
				"Zap-Cannon",
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
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Iron-Defense",
				"Block",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Toxic-Spikes",
				"Magnet-Rise",
				"Rock-Polish",
				"Giga-Impact",
				"Mirror-Shot",
				"Flash-Cannon",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Venoshock",
				"Autotomize",
				"Heavy-Slam",
				"Round",
				"Volt-Switch",
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