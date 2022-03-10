using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Metagross Species to store common natural stats of all Metagrosss
	#region SpeciesMetagross
	public class SpeciesMetagross : PokemonSpecies
	{
#nullable enable
		private static SpeciesMetagross? _instance = null;
#nullable restore
        public static SpeciesMetagross Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMetagross();
                }
                return _instance;
            }
        }

		#region SpeciesMetagross Constructor
		public SpeciesMetagross() : base(
			"Metagross",
			1.6,
			550.0,
			80, // HPs
			135, 130, // Attack & Defense
			95, 90, // Special Attack & Defense
			70		
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

	//Metagross PokemonInstance Class
	#region Metagross
	public class MetagrossInstance : PokemonInstance
	{
		#region Metagross Constructors
		/// <summary>
		/// Metagross Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MetagrossInstance(string nickname, int level)
		: base(
				376,
				SpeciesMetagross.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metagross Builder only waiting for a Level
		/// </summary>
		public MetagrossInstance(int level)
		: base(
				376,
				SpeciesMetagross.Instance, // PokemonInstance Species
				"Metagross", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metagross Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Metagross() : base(
			376,
			SpeciesMetagross.Instance, // PokemonInstance Species
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}