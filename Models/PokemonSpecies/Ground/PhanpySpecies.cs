using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Phanpy Species to store common natural stats of all Phanpys
	#region PhanpySpecies
	public class PhanpySpecies : PokemonSpecies
	{
#nullable enable
		private static PhanpySpecies? _instance = null;
#nullable restore
        public static PhanpySpecies Instance => _instance ?? (_instance = new PhanpySpecies());

		#region PhanpySpecies Constructor
		public PhanpySpecies() : base(
			231,
			"Phanpy",
			Ground.Instance,
			0.5,
			33.5,
			new PokemonStats(
				90, // HPs
				60, 60, // Attack & Defense
				40, 40, // Spacial Attack & Defense
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
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Water-Gun",
				"Counter",
				"Strength",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Natural-Gift",
				"Last-Resort",
				"Seed-Bomb",
				"Earth-Power",
				"Ice-Shard",
				"Gunk-Shot",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Heavy-Slam",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Play-Rough",
				"Confide",
				"High-Horsepower"
			};
		}
		#endregion
	}
	#endregion
}