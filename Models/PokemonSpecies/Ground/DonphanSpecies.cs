using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Donphan Species to store common natural stats of all Donphans
	#region DonphanSpecies
	public class DonphanSpecies : PokemonSpecies
	{
#nullable enable
		private static DonphanSpecies? _instance = null;
#nullable restore
        public static DonphanSpecies Instance => _instance ?? (_instance = new DonphanSpecies());

		#region DonphanSpecies Constructor
		public DonphanSpecies() : base(
			232,
			"Donphan",
			Ground.Instance,
			1.1,
			120.0,
			new PokemonStats(
				90, // HPs
				120, 120, // Attack & Defense
				60, 60, // Spacial Attack & Defense
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
				"Slam",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Roar",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Rapid-Spin",
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
				"Iron-Defense",
				"Block",
				"Bounce",
				"Gyro-Ball",
				"Natural-Gift",
				"Assurance",
				"Last-Resort",
				"Rock-Polish",
				"Poison-Jab",
				"Seed-Bomb",
				"Earth-Power",
				"Giga-Impact",
				"Thunder-Fang",
				"Fire-Fang",
				"Gunk-Shot",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}