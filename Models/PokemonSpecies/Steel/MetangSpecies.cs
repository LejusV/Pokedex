using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Metang Species to store common natural stats of all Metangs
	#region MetangSpecies
	public class MetangSpecies : PokemonSpecies
	{
#nullable enable
		private static MetangSpecies? _instance = null;
#nullable restore
        public static MetangSpecies Instance => _instance ?? (_instance = new MetangSpecies());

		#region MetangSpecies Constructor
		public MetangSpecies() : base(
			375,
			"Metang",
			Steel.Instance, Psychic.Instance,
			1.2,
			202.5,
			new PokemonStats(
				60, // HPs
				75, 100, // Attack & Defense
				55, 80, // Spacial Attack & Defense
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
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Swift",
				"Flash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Trick",
				"Brick-Break",
				"Secret-Power",
				"Meteor-Mash",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Gravity",
				"Miracle-Eye",
				"Gyro-Ball",
				"Natural-Gift",
				"Magnet-Rise",
				"Rock-Polish",
				"Bullet-Punch",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Iron-Head",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}