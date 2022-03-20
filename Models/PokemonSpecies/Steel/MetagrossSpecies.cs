using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Metagross Species to store common natural stats of all Metagrosss
	#region MetagrossSpecies
	public class MetagrossSpecies : PokemonSpecies
	{
#nullable enable
		private static MetagrossSpecies? _instance = null;
#nullable restore
        public static MetagrossSpecies Instance => _instance ?? (_instance = new MetagrossSpecies());

		#region MetagrossSpecies Constructor
		public MetagrossSpecies() : base(
			376,
			"Metagross",
			Steel.Instance, Psychic.Instance,
			1.6,
			550.0,
			new PokemonStats(
				80, // HPs
				135, 130, // Attack & Defense
				95, 90, // Spacial Attack & Defense
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
				"Block",
				"Gravity",
				"Miracle-Eye",
				"Hammer-Arm",
				"Gyro-Ball",
				"Natural-Gift",
				"Magnet-Rise",
				"Rock-Polish",
				"Giga-Impact",
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